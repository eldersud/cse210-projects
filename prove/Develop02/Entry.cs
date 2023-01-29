using System;
class Entry
    {
        private List<string> _entry = new List<string>();

        public void memoryTemp(String promt, string response, String dateCurrent) {
            _entry.Add($"{dateCurrent} - Prompt: {promt}");
            _entry.Add(response);
            _entry.Add("");
        }

        public void Display()
        {
            foreach (string item in _entry)
                {
                    Console.WriteLine(item);
                }
        }

        public List<string> GetList()
        {
            return _entry;
        }
    }