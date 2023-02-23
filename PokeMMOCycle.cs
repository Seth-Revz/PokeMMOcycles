using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PokeMMOCycleGUI
{
    class PokeMMOCycle
    {
        public int Cycle 
        {
            get
            {
                DateTime now = DateTime.Now.ToUniversalTime();
                TimeSpan difference = now.Subtract(cycle1_Offset);
                long currentCycle = difference.Ticks / cycleLength.Ticks % nbCycle;
                return (int) currentCycle + 1;
            }
        }

        public TimeSpan TimeLeft
        {
            get
            {
                DateTime now = DateTime.Now.ToUniversalTime();
                TimeSpan difference = now.Subtract(cycle1_Offset);
                long pastCycles = difference.Ticks / cycleLength.Ticks;

                DateTime CycleEnd = cycle1_Offset.AddTicks((pastCycles+1) * cycleLength.Ticks);

                return CycleEnd.Subtract(now);
            }
        }

        public int nbCycle = 7;
        public DateTime cycle1_Offset = new DateTime(2023, 2, 23, 6, 00, 00); // Cycle 1 starting time mesure (UTC)
        public TimeSpan cycleLength = new TimeSpan(6,0,0); // one cycle is 6 hours

        private String[][,] cyclesTab;

        public static readonly string xmlPath = "./Resources/Cycles.xml";
        public XmlDocument _doc;

        public PokeMMOCycle()
        {
            init();
        }


        public String[,] PokemonListCurrentCycle
        {
            get
            {
                return cyclesTab[0];
            }
        }

        // load the XML and initiate the array CycleTab
        public void init()
        {
            OpenXML();

            XmlNodeList cycles = _doc.SelectNodes("//Cycle");
            cyclesTab = new String[cycles.Count][,];
            foreach (XmlNode xCycle in cycles)
            {
                int id;
                if (int.TryParse(xCycle.Attributes["id"].Value, out id))
                {
                    id--;
                    XmlNodeList pokemons = xCycle.SelectNodes("Pokemon");
                    cyclesTab[id] = new String[pokemons.Count,3];
                    for(int i = 0; i < pokemons.Count; i++)
                    {
                        cyclesTab[id][i, 0] = pokemons[i]["Name"].InnerText;
                        cyclesTab[id][i, 1] = pokemons[i]["EncounterRate"].InnerText;
                        cyclesTab[id][i, 2] = pokemons[i]["Level"].InnerText;
                    }
                }
            }
        }

        private void OpenXML()
        {
            //("loading data");
            _doc = new XmlDocument();
            Boolean done;
            int nbTry = 0; // after 3 tries, we stop trying
            do
            {
                try
                {
                    _doc.Load(xmlPath);
                    done = true;
                }
                catch (Exception e)
                {
                    if (e is System.IO.FileNotFoundException) // the file doesn't exist, let's create it with the last data available (05 july 2013) Removed Shuckle.
                    {
                        done = false;
                        XmlElement cycles = _doc.CreateElement("Cycles");

                        String[][,] cyclesTab = new String[][,]
                                                { 
                                                    new String[,]{ // cycle 1
                                                        {"Houndour", "9", "18-28"},
                                                        {"Aipom", "10", "12-20"},
                                                        {"Pineco", "10", "5-16"},
                                                        {"Mareep", "10", "18-28"},
                                                        {"Smeargle", "1", "19-29"},
                                                        {"Stantler", "5", "18-28"},
                                                        {"Teddiursa", "10", "5-16"},
                                                        {"Zubat", "35", "5-16"},
                                                    }, 
                                                    new String[,]{ // cycle 2
                                                        {"Bagon", "0,5", "18-25"},
                                                        {"Stantler", "6,5", "12-20"},
                                                        {"Snubbull", "8", "18-28"},
                                                        {"Poochyena", "8", "5-16"},
                                                        {"Teddiursa", "8", "5-16"},
                                                        {"Smeargle", "8", "19-29"},
                                                        {"Zubat", "53", "10-20"},
                                                    },
                                                    new String[,]{ // cycle 3
                                                        {"Mawile", "1", "18-25"},
                                                        {"Poochyena", "9", "12-20"},
                                                        {"Snubbull", "10", "18-28"},
                                                        {"Slakoth", "10", "12-16"},
                                                        {"Spinda", "10", "19-29"},
                                                        {"Mareep", "10", "18-26"},
                                                        {"Sableye", "15", "12-28"},
                                                        {"Zubat", "35", "18-25"},
                                                    },
                                                    new String[,]{ // cycle 4
                                                        {"Zubat", "100", "18-25"},
                                                    },
                                                    new String[,]{ // cycle 5
                                                        {"Unown", "1", "18-25"},
                                                        {"Mawile", "5", "12-20"},
                                                        {"Poochyena", "9", "12-16"},
                                                        {"Mareep", "10", "18-28"},
                                                        {"Teddiursa", "10", "12-20"},
                                                        {"Spinda", "10", "19-29"},
                                                        {"Zubat", "45", "5-16"}
                                                    },
                                                    new String[,]{ // cycle 6
                                                        {"Absol", "0,5", "18-25"},
                                                        {"Duskull", "6,5", "12-20"},
                                                        {"Shuppet", "8", "18-28"},
                                                        {"Pineco", "8", "19-29"},
                                                        {"Houndour", "8", "5-16"},
                                                        {"Zigzagoon", "8", "5-16"},
                                                        {"Aipom", "8", "18-28"},
                                                        {"Snubbull", "8", "18-26"},
                                                        {"Zubat", "45", "5-16"}
                                                    },
                                                    new String[,]{ // cycle 7
                                                        {"Aron", "0,5", "18-28"},
                                                        {"Stantler", "6,5", "12-20"},
                                                        {"Shuppet", "8", "18-28"},
                                                        {"Pineco", "8", "19-29"},
                                                        {"Poochyena", "8", "5-16"},
                                                        {"Zigzagoon", "8", "5-16"},
                                                        {"Aipom", "8", "18-28"},
                                                        {"Snubbull", "8", "18-26"},
                                                        {"Zubat", "45", "5-16"}
                                                    }
                                                };
                        for (int i = 0; i < cyclesTab.Length; i++)
                        { // going through the cycles
                            XmlElement cycle = _doc.CreateElement("Cycle");
                            XmlAttribute idCycle = _doc.CreateAttribute("id");
                            idCycle.Value = (i+1).ToString();
                            cycle.Attributes.Append(idCycle);

                            for (int j = 0; j < cyclesTab[i].GetLength(0); j++)
                            { // going through the pokemons
                                XmlElement pokemon = _doc.CreateElement("Pokemon");
                                XmlElement Name = _doc.CreateElement("Name");
                                Name.InnerText = cyclesTab[i][j, 0];
                                XmlElement EncouterLevel = _doc.CreateElement("EncounterRate");
                                EncouterLevel.InnerText = cyclesTab[i][j, 1];
                                XmlElement Level = _doc.CreateElement("Level");
                                Level.InnerText = cyclesTab[i][j, 2];
                                pokemon.AppendChild(Name);
                                pokemon.AppendChild(EncouterLevel);
                                pokemon.AppendChild(Level);

                                cycle.AppendChild(pokemon);
                            }

                            cycles.AppendChild(cycle);
                        }

                        _doc.AppendChild(cycles);
                        _doc.Save(xmlPath);
                    }
                    else
                    {
                        done = false;
                    }
                }
                nbTry++;
            } while (!done && nbTry < 3);

            if (!done)
            {
                // the file hasn't been loaded.
            }
            else
            {
                //the file has been loaded
            }
            
        }
    }
}
