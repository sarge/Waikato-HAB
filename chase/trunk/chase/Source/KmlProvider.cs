using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace Demo.WindowsForms.Source
{
    public class KmlProvider
    {
        XDocument loaded;

        List<PointLatLng> points;

        public KmlProvider(string filePath)
        {
            Load(filePath);
        }

        private void Load(string filePath)
        {
            loaded = XDocument.Load(filePath);

            XNamespace nx = "http://www.opengis.net/kml/2.2";

            var flightPath = from placeMark in loaded.Descendants(nx + "Placemark")
                             where placeMark.Element(nx + "name").Value == "Flight path"
                             select placeMark;

            var r = from coords in flightPath.Descendants(nx + "coordinates")
                    from coord in coords.Value.Split('\n')
                    where !string.IsNullOrWhiteSpace(coord)
                    select ParseCoordinate(coord);
            points = r.ToList();

        }

        public GMapRoute CreateRoute()
        {
            // add route
            return new GMapRoute(points, "KML");
        }

        private PointLatLng ParseCoordinate(string coordinate)
        {
            return new PointLatLng(
                        double.Parse(coordinate.Split(',')[1]),
                        double.Parse(coordinate.Split(',')[0]));

        }

        public List<GMapMarker> GetMarkers()
        {
            XNamespace nx = "http://www.opengis.net/kml/2.2";

            var placemarks = from placeMark in loaded.Descendants(nx + "Placemark")
                             where placeMark.Element(nx + "name").Value != "Flight path"
                             select placeMark;

            List<GMapMarker> markers = new List<GMapMarker>();

            placemarks.ToList().ForEach((placemark) =>{
                    var location = ParseCoordinate(placemark.Descendants(nx + "coordinates").First().Value);

                    GMapMarker marker;

                    if (placemark.Descendants(nx + "name").First().Value.Contains("Landing"))
                        marker = new GMapMarkerGoogleGreen(location);
                    else
                        marker = new GMapMarkerGoogleRed(location);

                    marker.ToolTipText = placemark.Descendants(nx + "description").First().Value;
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    markers.Add(marker);
                });

            return markers;
        }
    }
}
