using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace CSharpFirebase
{
    public class FirebaseConnection
    {
        private IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = DboAnahtar.AuthSecret,
            BasePath = DboAnahtar.BasePath
        };

        private IFirebaseClient client = null;
        private SetResponse response = null;
        private FirebaseResponse response_ = null;
        private List<Student> studentList = null;

        protected internal string ConnectionTest(string x=null)
        {
            client = new FirebaseClient(config);

            if (client == null)
            {
                return "Başarısız! Bağlantı sağlanamadı.";
            }

            return "Başarılı! Bağlantı sağlandı.";
        }

        protected internal async Task<List<Student>> ListStudent()
        {
            studentList = new List<Student>();
            response_ = await client.GetAsync("Students");
            var result = response_.Body;
            var data = JsonConvert.DeserializeObject<Dictionary<string, Student>>(result);
            
            foreach (var student in data)
            {
                studentList.Add((Student)(student.Value));
            }

            return studentList;
        }

        protected internal async void AddStudent(Student model)
        {
            if (client != null)
            {
                response = await client.SetAsync("Students/" + model.Id + "/", model);
                var result = response.ResultAs<Student>();
                if (result == null)
                {
                    throw new Exception("Ekleme sırasında hata meydana geldi.");
                }
            }
            else
            {
                throw new Exception("Bağlantı başarısız.");
            }
        }

        protected internal async void UpdateStudent(Student model)
        {
            if (client != null)
            {
                var response = await client.UpdateAsync("Students/" + model.Id, model);
                var result = this.response.ResultAs<Student>();

                if (result == null)
                {
                    throw new Exception("Güncelleme sırasında hata meydana geldi.");
                }
            }
            else
            {
                throw new Exception("Bağlantı başarısız.");
            }
        }

        protected internal async void DeleteStudent(string id)
        {
            if (client!=null)
            {
                var response = await client.DeleteAsync("Students/" + id);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Silme sırasında hata meydana geldi.");
                }
            }
        }
    }
}
