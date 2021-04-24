using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var novelist = new Novelist
            {
                Name = "test", Birth = new DateTime(2021, 4, 24), Masterpieces = new[] {"test"}
            };
            Exercise2_2(novelist, "novelist.json");
            Console.WriteLine(File.ReadAllText("novelist.json"));
            Console.WriteLine();
        }

        static void Exercise2_2(Novelist novelist, string outfile)
        {
            using (var stream = new FileStream(outfile, FileMode.Create,
                FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(novelist.GetType(),
                    new DataContractJsonSerializerSettings
                    {
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                    });
                serializer.WriteObject(stream, novelist);
            }
        }
    }

    [DataContract]
    class Novelist
    {
        [DataMember(Name = "name")] public string Name { get; set; }
        [DataMember(Name = "birth")] public DateTime Birth { get; set; }
        [DataMember(Name = "masterpieces")] public string[] Masterpieces { get; set; }
    }
}