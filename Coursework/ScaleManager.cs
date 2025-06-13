using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;

namespace Coursework
{
    public class ScaleManager : IScaleManager
    {
        private List<DigitalScale> scales = new List<DigitalScale>();
        private DigitalScale? selectedScale = null;
        private int nextScaleId = 1;

        public void AddScale(DigitalScale scale)
        {
            scale.Id = nextScaleId++;
            scales.Add(scale);
        }

        public void RemoveScale(int index)
        {
            if (index < 0 || index >= scales.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid scale index");

            scales.RemoveAt(index);
        }

        //public void SelectScale(int scaleId)
        //{
        //    selectedScale = scales.FirstOrDefault(s => s.Id == scaleId);
        //}

        public int FindScaleIndexById(int id)
        {
            return scales.FindIndex(s => s.Id == id);
        }
        
        //public void EditScaleById(int id, Action<DigitalScale> editAction)
        //{
        //    var index = FindScaleIndexById(id);
        //    if (index >= 0)
        //        editAction(scales[index]);
        //    else
        //        throw new ArgumentException($"Scale with ID {id} not found");
        //}

        public double CalculateTotalWeighingError()
        {
            double sum = 0.0;

            foreach (var scale in scales)
            {
                foreach (var entry in scale.GetWeighingLog())
                {
                    sum += Math.Pow(entry.Mass * entry.Error, 2);
                }
            }

            return Math.Sqrt(sum);
        }

        public DigitalScale? GetSelectedScale() => selectedScale;

        public List<DigitalScale> GetAllScales() => scales;





        // ==== JSON & XML Serialization/Deserialization ====

        // JSON
        public void SaveToJson(string path)
        {
            try
            {
                var json = JsonSerializer.Serialize(scales, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
                MessageBox.Show("Scales successfully saved to JSON.", "Saved");
                
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("File error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving to file: " + ex.Message);
            }
        }

        public void LoadFromJson(string path)
        {
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException("File not found.");

                string json = File.ReadAllText(path);
                var loaded = JsonSerializer.Deserialize<List<DigitalScale>>(json);

                if (loaded == null)
                    throw new Exception("Deserialization failed.");

                scales = loaded;
                nextScaleId = scales.Any() ? scales.Max(s => s.Id) + 1 : 1;

                MessageBox.Show("Scales loaded successfully from JSON.", "Loaded");
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("File error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading from file: " + ex.Message);
            }
        }
        // XML
        public void SaveToXml(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<DigitalScale>));
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fs, scales);
                }

                MessageBox.Show("Scales successfully saved to XML.", "Saved");
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("File error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving to file: " + ex.Message);
            }
        }

        public void LoadFromXml(string path)
        {
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException("File not found.");

                XmlSerializer serializer = new XmlSerializer(typeof(List<DigitalScale>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    var loaded = (List<DigitalScale>)serializer.Deserialize(fs);
                    scales = loaded;
                    nextScaleId = scales.Any() ? scales.Max(s => s.Id) + 1 : 1;
                }

                MessageBox.Show("Scales loaded successfully from XML.", "Loaded");
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("File error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading from file: " + ex.Message);
            }
        }


        // ==== Custom Iterator ====

        public IEnumerator<DigitalScale> GetEnumerator()
        {
            return new ScaleEnumerator(scales);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class ScaleEnumerator : IEnumerator<DigitalScale>
        {
            private readonly List<DigitalScale> scales;
            private int position = -1;

            public ScaleEnumerator(List<DigitalScale> scales)
            {
                this.scales = scales;
            }

            public DigitalScale Current
            {
                get
                {
                    if (position < 0 || position >= scales.Count)
                        throw new InvalidOperationException();
                    return scales[position];
                }
            }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                position++;
                return position < scales.Count;
            }

            public void Reset()
            {
                position = -1;
            }

            public void Dispose() { }
        }

    }
}
