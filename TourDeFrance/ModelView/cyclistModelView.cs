using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDeFrance.Model;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;
using System.Windows;

namespace TourDeFrance.ModelView
{
    class cyclistModelView
    {
        public void getCyclist()
        {


            List<Cyclist> cyclists = new List<Cyclist>();

            XDocument xdoc = XDocument.Load("Cycling-Tour-De-France.xml");

            IEnumerable<XElement> xes = from item in xdoc.Descendants("event_participant") select item;

            foreach (var el in xes)
            {

                string name = el.Element("participant").Attribute("name").Value.ToString();
                string gender = el.Element("participant").Attribute("gender").Value.ToString();
                string countryOrigin = el.Element("participant").Attribute("countryFK").Value.ToString();
                cyclists.Add(new Cyclist
                {
                    name = name,
                    gender = gender,
                    countryOrigin = countryOrigin
                });

            }
            MessageBox.Show(cyclists[3].countryOrigin);

        }
    }    
}

