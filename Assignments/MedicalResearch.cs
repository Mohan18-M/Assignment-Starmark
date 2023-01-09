using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework.cs.Practical
{
    class Disease
    {
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
    }

    class DiseaseManager
    {
        private Disease[] _diseases = null;
        private int _size = 0;
        public DiseaseManager(int size)
        {
            _size = size;
            _diseases = new Disease[_size];
        }

        public int AddDiseaseDetails(Disease disease)
        {
            for(int i = 0; i < _size; i++)
            {
                if(_diseases[i] == null)
                {
                    _diseases[i] = new Disease
                    {
                        DiseaseID = i,
                        DiseaseName = disease.DiseaseName,
                        Severity = disease.Severity,
                        Description = disease.Description
                    };
                    return _diseases[i].DiseaseID;

                }
            }
            throw new Exception("Unable to complete the process");
        }

        
    }

    enum Options
    {
        AddDisease, AddSymptom, CheckPatient
    }

    class UI
    {
        public const string menu = "----------Medical Research Software------------" +
            "\nTo Add Disease Details------>Press 1\nTo Add Symptom Details----->Press 2" +
            "\nTo Check Patient--------->Press 3\nEnter any key to Exit...........";
        private static DiseaseManager dis;

        public static void View()
        {
            int size = Utilities.GetNumber("Enter the Disease details to store");
            dis = new DiseaseManager(size);
            bool processing = true;
            do
            {
                Options options = (Options)Utilities.GetNumber(menu);
                processing = processMenu(options);
            }
            while (processing);
            Console.WriteLine("Thanks for using out application");
        }
        private static bool processMenu(Options options)
        {
            switch (options)
            {
                case Options.AddDiseaseDetails();
                    break;
                case Options.AddSymptomDetails();
                    break;
                case Options.CheckPatientDetails();
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
    class Patient
    {
        string Name;
        string Disease;
        string Symptom;

        public string PatientName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string PatientDisease
        {
            get { return Disease; }
            set { Disease = value; }
        }
        public string PatientSymptom
        {
            get { return Symptom; }
            set { Symptom = value; }
        }
    }

    private void AddDisease()
    {
        string DiseaseName = Utilities.Prompt("Enter the Disease Name");
    }
    class MedicalResearch
    {
        static void Main(string[] args)
        {
            UI.View();
            

        }
    }
}
