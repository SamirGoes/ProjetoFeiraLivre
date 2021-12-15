using FeiraLivre.Api.Models;
using System.IO;

namespace FeiraLivre.Api.Services
{
    public class ReadFeiraCsv
    {
        public ReadFeiraCsv(string path)
        {
            Path = path;
        }

        public string Path { get; }

        public IEnumerable<string> ReadCommaLine(string line, char delimiter)
        {
            List<char> chars = new List<char> ();
            
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == delimiter) {
                    yield return new String(chars.ToArray());
                    chars.Clear();
                    continue;
                }

                chars.Add(line[i]);
            }
        }
        public IEnumerable<Feira> LoadData()
        {
            using(var reader = new StreamReader(this.Path))
            {
                int index = 0;
                
                while(!reader.EndOfStream)
                {
                    if(index == 0) continue;
                    
                    var lines = ReadCommaLine(reader.ReadLine(), ',').ToArray();

                    Feira feira = new();
                    feira.Id = Convert.ToInt32(lines[0]);
                    feira.Longitude = Convert.ToInt64(lines[1]);
                    feira.Latitude = Convert.ToInt64(lines[2]);
                    feira.SetCens = Convert.ToInt64(lines[3]);
                    feira.Areap = Convert.ToInt64(lines[4]);
                    feira.CodDist = Convert.ToInt32(lines[4]);
                    feira.Distrito = lines[5];
                    feira.CodSubprefitura = Convert.ToInt32(lines[6]);
                    feira.SubPrefeitura = lines[7];
                    feira.Regiao05 = lines[8];
                    feira.Regiao08 = lines[9];
                    feira.NomeFeira = lines[10];
                    feira.Registro = lines[11];
                    feira.Logradouro = lines[12];
                    feira.Numero = Convert.ToInt32(lines[13]);
                    feira.Bairro = lines[14];
                    feira.Referencia = lines[15];

                    yield return feira;
                    index++;
                }
            }
        }
    }
}