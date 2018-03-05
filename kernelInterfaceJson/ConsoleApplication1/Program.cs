using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleKernelAPI.dataModel;
using Newtonsoft.Json;


namespace ConsoleKernelAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathRoot = @"D:\testing\DStability\json\pruebasC_sharp\kernelInterfaceJson";


            string jsonSoil =
                @"{'SoilCollection':[{'Description':'Zand','SoilGamDry':20,'SoilCohesion':0,'SoilPhi':45,'SoilDilatancy':45}]}";

            string jsonLEM = @"{'Lem': ['Bishop']}";


            string jsonCircles = @"{'Circles': [ {'XValue': 66.0, 'YValue' : 52.5, 'TangentValue' : 39.35}] }";

            string jsonGeometry = @"{'Geometry':{'Nodes':[{'X': 0.000,'Z' : 100.000},
                                                          {'X':100.000,'Z': 0.000},
                                                          {'X':0.000,'Z':-50.000},
                                                          {'X':100.000,'Z':-50.000}],
                                                 'Layers' : [{'Area' : [0,1,2,3], 'Material' : 'Zand'}]
                                                }
                                    }";

            string jsonAll = @"{
                                        'SoilCollection':[{'Description':'Zand','SoilGamDry':20,'SoilCohesion':0,'SoilPhi':45,'SoilDilatancy':45}],
                                        'Lem': ['Bishop'],
                                        'Circles': [ {'XValue': 66.0, 'YValue' : 52.5, 'TangentValue' : 39.35}],
                                        'Geometry':{'Nodes':[{'X': 0.000,'Z' : 100.000},
                                                             {'X':100.000,'Z': 0.000},
                                                             {'X':0.000,'Z':-50.000},
                                                             {'X':100.000,'Z':-50.000}],
                                                    'Layers' : [{'Area' : [0,1,2,3], 'Material' : 'Zand'}]
                                                    },
                                    }";
            DataModel myDataModel = new DataModel();

            JsonConvert.PopulateObject(jsonSoil, myDataModel);
            JsonConvert.PopulateObject(jsonLEM, myDataModel);
            JsonConvert.PopulateObject(jsonCircles, myDataModel);
            JsonConvert.PopulateObject(jsonGeometry, myDataModel);

            DataModel myDataModel2 = new DataModel();

            JsonConvert.PopulateObject(jsonAll, myDataModel2);

            string sourcePath = pathRoot + @"\testSource.json";
            DataModel myDataModel3 = JsonConvert.DeserializeObject<DataModel>(File.ReadAllText(sourcePath));





            string back2Json = JsonConvert.SerializeObject(myDataModel, Formatting.Indented);
            string back2Json2 = JsonConvert.SerializeObject(myDataModel2, Formatting.Indented);
            string back2Json3 = JsonConvert.SerializeObject(myDataModel3, Formatting.Indented);

            File.WriteAllText(pathRoot + @"\testParts.json", back2Json);
            File.WriteAllText(pathRoot + @"\testOneGo.json", back2Json2);
            File.WriteAllText(pathRoot + @"\testFile.json", back2Json3);


            Console.WriteLine();
        }
    }
}
