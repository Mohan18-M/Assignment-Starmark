using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramework.cs.Practical
{
 class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string Disease { get; set; }
        public string Symptoms { get; set; }
    }
    class Disease
    {
        public string DiseaseName { get; set; }
        public string Severity { get; set; }
    }

    class Symptom
    {
        public string DiseaseName { get; set; }
        public string Symptoms { get; set; }
        public string Discription { get; set; }
    }

    //interface Sample
    //{
    //    void AddDisease(Disease disease);
    //    void AddSymptoms(Symptom symptom);
    //    void CheckPatient();
    //}

    class MedResearchManager 
    {
        private Disease[] diseases = null;
            private Symptom[] symptoms = null;
        int _size = 0;

        public MedResearchManager(int size)
        {
            _size = size;
            symptoms= new Symptom[_size];
            diseases = new Disease[_size];
        }

        public void AddDisease(Disease disease)
        {
            for(int i=0;i<diseases.Length;i++)
            {
                if (diseases[i] == null)
                {
                    diseases[i] = new Disease { DiseaseName = disease.DiseaseName, Severity = disease.Severity };
                    return;
                }
            }
            throw new Exception("This type of Disease not Exist");
        }
        public void AddSymptom(Symptom symptom)
        {
            for (int i = 0; i < diseases.Length; i++)
            {
                symptoms[i] = new Symptom { DiseaseName = symptom.DiseaseName, Symptoms = symptom.Symptoms, Discription = symptom.Discription };
                return;

            }
        }
        public void Patient()
        {
            Console.WriteLine("Enter the Patient Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter the Symptoms");
            string SymptomType = Console.ReadLine();
            if(diseases != null)
            {
                for(int i=0;i<diseases.Length;i++)
                {
                    try
                    {
                      if (symptoms[i].Symptoms.Contains(SymptomType))
                        {
                            Console.WriteLine("Disease : " + symptoms[i].DiseaseName);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }

     class MedicalResearchApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());

            MedResearchManager medResearchManager = new MedResearchManager(size);
            void addDisease()
            {
                Console.WriteLine("Enter the Disease Name");
                string disease = Console.ReadLine();

                Console.WriteLine("Enter the Severity");
                string severity = Console.ReadLine();

                Disease disease1 = new Disease { DiseaseName = disease, Severity = severity };
                medResearchManager.AddDisease(disease1);
            }

            void addSymptom()
            {
                Console.WriteLine("Enter the Disease Name");
                string disease = Console.ReadLine();

                Console.WriteLine("Enter the Symptoms");
                string symptom = Console.ReadLine();
                Console.WriteLine("Enter the Description");
                string description = Console.ReadLine();

                Symptom symptom1 = new Symptom { DiseaseName = disease, Symptoms = symptom, Discription = description };
                medResearchManager.AddSymptom(symptom1);
            }
            void checkPatient()
            {
                medResearchManager.Patient();
            }
            bool processing = true;
            do
            {
                Console.WriteLine("--------------Medical Research Application----------");
                Console.WriteLine("To Add Disease Details ----->Press 1\n To Add Symptom Details ------>Press 2\n To Check Patient Details ---------> Press 3");
                string choices = Console.ReadLine();
                switch (choices)
                {
                    case "1":
                        addDisease();
                        break;
                    case "2":
                        addSymptom();
                        break;
                    case "3":
                        checkPatient();
                        break;
                }
            }
            while (processing);
        }
    }
}

   
