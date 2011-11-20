using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Text.RegularExpressions;
using GMap.NET;

namespace Demo.WindowsForms.Source
{
    public class GPSComDevice
    {
        SerialPort serial = null;

        Regex latLong = new Regex(@"^Lat/Long\(float\):\s(?<lat>-{0,1}\d*\.\d*),\s(?<long>-{0,1}\d*\.\d*)\s");

        public event EventHandler<SerialDataArgs> RawData;

        public event EventHandler<SerialDataArgs> NewCoordinatesRecieved;

        protected void OnRawData(string data)
        {
            if (RawData != null)
                RawData(this, new SerialDataArgs() { RawData = data });
        }

        protected void OnNewCoordinatesRecieved(PointLatLng location)
        {
            if (NewCoordinatesRecieved != null)
                NewCoordinatesRecieved(this, new SerialDataArgs() { Location = location });
        }

        public void ConnectToSerial(string portName)
        {
            CloseExistingConnection();

            serial = new SerialPort(portName, 4800, Parity.None, 8, StopBits.One);
            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
            serial.Open();
        }

        public void ConnectArduinoToSerial(string portName)
        {
            CloseExistingConnection();

            serial = new SerialPort(portName, 115200);
            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
            serial.Open();
        }

        private void CloseExistingConnection()
        {
            if (serial != null)
            {
                serial.Close();
                serial.DataReceived -= new SerialDataReceivedEventHandler(serial_DataReceived);
            }
        }

        void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            var data = serial.ReadLine();
            try
            {
                if (data.StartsWith("$GPGGA"))
                {
                    //$GPGGA,000618.000,3748.0659,S,17518.1864,E,1,04,4.0,94.8,M,23.6,M,,0000*7F\r

                    var parts = data.Split(',');

                    var lat = double.Parse(parts[2]) / 100.0;
                    if (parts[3] == "S")
                        lat = -lat;

                    var lng = double.Parse(parts[4]) / 100.0;
                    if (parts[5] == "W")
                        lng = -lng;

                    OnNewCoordinatesRecieved(new PointLatLng(lat, lng));
                }
                else
                {
                    Match result = latLong.Match(data);
                    if (result.Success)
                    {
                        OnNewCoordinatesRecieved(
                            new PointLatLng(
                                double.Parse(result.Groups["lat"].Value),
                                double.Parse(result.Groups["long"].Value)));
                    }

                }
            }
            catch (Exception ex)
            {
            }
            OnRawData(data);

        }
    }

    public class SerialDataArgs : EventArgs
    {
        public string RawData { get; set; }

        public GMap.NET.PointLatLng Location { get; set; }
    }
}
