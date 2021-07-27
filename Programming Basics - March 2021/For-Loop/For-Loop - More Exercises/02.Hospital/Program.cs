using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int doctors = 7;
            int days = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int day = 1; day <= days; day++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (day % 3 == 0 && treatedPatients < untreatedPatients)
                {
                    doctors++;
                }
                
                if (doctors >= patients)
                {
                    treatedPatients += patients;
                }
                else if (patients > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patients - doctors;
                }
            }
            
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
