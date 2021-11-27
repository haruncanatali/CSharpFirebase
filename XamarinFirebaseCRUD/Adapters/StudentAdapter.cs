using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinFirebaseCRUD.Adapters
{
    public class StudentAdapter : BaseAdapter<Student>
    {
        private Context context;
        private List<Student> studentList = null;
        private FirebaseConnection connection = null;
        private string sinif = "-1";

        public StudentAdapter(Context context, List<Student> studentList)
        {
            this.context = context;
            this.studentList = studentList;
            this.connection = new FirebaseConnection();
            this.connection.ConnectionTest();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View? GetView(int position, View? convertView, ViewGroup? parent)
        {
            View satir = convertView;
            satir = LayoutInflater.From(context).Inflate(Resource.Layout.ogrenci_liste_satir, null, false);

            TextView AdSoyadSinifControl = satir.FindViewById<TextView>(Resource.Id.adSoyadSinifTxt);
            TextView IdControl = satir.FindViewById<TextView>(Resource.Id.IdTxtListView);

            AdSoyadSinifControl.Text = studentList[position].Name + " " + studentList[position].Surname + " " +
                                       studentList[position].Grade;
            IdControl.Text = studentList[position].Id;


            satir.LongClick += delegate
            {
                LayoutInflater infilater = LayoutInflater.From(Application.Context);
                View v = infilater.Inflate(Resource.Layout.add_or_update_student, null);
                View v_ = infilater.Inflate(Resource.Layout.activity_main, null);

                Spinner sinifSpinControl = v.FindViewById<Spinner>(Resource.Id.sinifSpinEkle);
                EditText adTxtGuncelle = v.FindViewById<EditText>(Resource.Id.ogrenciAdiTxtEkle);
                EditText soyadTxtGuncelle = v.FindViewById<EditText>(Resource.Id.ogrenciSoyadiTxtEkle);

                var adapter = ArrayAdapter.CreateFromResource(this.context, Resource.Array.siniflarElements,
                    Android.Resource.Layout.SimpleSpinnerItem);

                adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                sinifSpinControl.Adapter = adapter;

                sinifSpinControl.ItemSelected +=
                    new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_itemSelected);

                ArrayAdapter myAdap = (ArrayAdapter)sinifSpinControl.Adapter;
                int innerPosition = myAdap.GetPosition(studentList[position].Grade);

                sinifSpinControl.SetSelection(innerPosition);
                adTxtGuncelle.Text = studentList[position].Name;
                soyadTxtGuncelle.Text = studentList[position].Surname;


                Android.Support.V7.App.AlertDialog.Builder alertDialog = new Android.Support.V7.App.AlertDialog.Builder(this.context, Resource.Style.AppCompatAlertDialogStyle);
                alertDialog.SetView(v);
                alertDialog.SetTitle("Öğrenci Güncelle/Sil Ekranı");

                alertDialog.SetPositiveButton("Güncelle", delegate
                {
                    try
                    {
                        connection.UpdateStudent(new Student
                        {
                            Id = studentList[position].Id,
                            Name = adTxtGuncelle.Text,
                            Surname = soyadTxtGuncelle.Text,
                            Grade = sinif
                        });
                        Toast.MakeText(this.context, "Güncelleme başarılı oldu.", ToastLength.Long).Show();
                        ListeGuncelle(v_);
                    }
                    catch (Exception ex)
                    {
                        Toast.MakeText(this.context, "Hata! Mesaj:" + ex.Message, ToastLength.Long).Show();
                    }
                    
                    alertDialog.Dispose();
                });
                alertDialog.SetNegativeButton("Sil", delegate
                {
                    try
                    {
                        connection.DeleteStudent(studentList[position].Id);
                        Toast.MakeText(this.context,"Silme başarılı oldu.",ToastLength.Long).Show();
                        ListeGuncelle(v_);

                    }
                    catch (Exception e)
                    {
                        Toast.MakeText(this.context, "Hata! Mesaj:" + e.Message, ToastLength.Long).Show();
                    }
                    alertDialog.Dispose();
                });
                alertDialog.Show();
            };

            return satir;
        }

        private async void ListeGuncelle(View v)
        {
            ListView ls = v.FindViewById<ListView>(Resource.Id.ogrenciListView);
            studentList = new List<Student>();
            studentList = await connection.ListStudent();

            StudentAdapter adapter = new StudentAdapter(this.context, studentList);
            ls.Adapter = adapter;
        }

        private void spinner_itemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = sender as Spinner;
            sinif = spinner.GetItemAtPosition(e.Position).ToString();
        }

        public override int Count
        {
            get { return studentList.Count; }
        }

        public override Student this[int position]
        {
            get { return studentList[position]; }
        }
    }
}