using System;
class Journal
    {
        public void Save(List<string> calledListe)
        {
            Console.Write("Save as: ");
            string _create_file = Console.ReadLine();
            List<string> _lines = new List<string>();
            foreach (string item in calledListe)
            {
                _lines.Add(item);
            }
            File.WriteAllLines(_create_file, _lines);
        }
        public void Load()
        {
            List<string> _entry = new List<string>();
            Console.Write("Open File: ");
            string _ReadFile = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(_ReadFile);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }