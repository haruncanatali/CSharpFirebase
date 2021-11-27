using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using XamarinFirebaseCRUD.Adapters;
using AlertDialog = Android.Support.V7.App.AlertDialog;

namespace XamarinFirebaseCRUD
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar toolbar = null;
        private string sinif = null;
        private FirebaseConnection connection = new FirebaseConnection();
        private ListView ogrencilerListView;
        private List<Student> studentList = null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            ToolbarTanimla();
            Tanimla();
        }

        private async void Tanimla()
        {
            Toast.MakeText(this,connection.ConnectionTest(),ToastLength.Long).Show();
            ogrencilerListView = FindViewById<ListView>(Resource.Id.ogrenciListView);
            ListeDoldur();
        }

        private async void ListeDoldur()
        {
            studentList = new List<Student>();
            studentList = await connection.ListStudent();

            StudentAdapter adapter = new StudentAdapter(this, studentList);
            ogrencilerListView.Adapter = adapter;
        }

        private void ToolbarTanimla()
        {
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar1);
            SetSupportActionBar(toolbar);

            SupportActionBar.Title = "Xamarin Firebase CRUD";
        }

        public override bool OnCreateOptionsMenu(IMenu? menu)
        {
            MenuInflater.Inflate(Resource.Menu.toolbar_menu,menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.menu_add)
            {
                LayoutInflater infilater = LayoutInflater.From(Application.Context);
                View v = infilater.Inflate(Resource.Layout.add_or_update_student, null);

                EditText adTxt = v.FindViewById<EditText>(Resource.Id.ogrenciAdiTxtEkle);
                EditText soyadTxt = v.FindViewById<EditText>(Resource.Id.ogrenciSoyadiTxtEkle);
                Spinner sinifSpinControl = v.FindViewById<Spinner>(Resource.Id.sinifSpinEkle);

                sinifSpinControl.ItemSelected +=
                    new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_itemSelected);
                var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.siniflarElements,
                    Android.Resource.Layout.SimpleSpinnerItem);

                adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                sinifSpinControl.Adapter = adapter;

                Android.Support.V7.App.AlertDialog.Builder alertDialog = new Android.Support.V7.App.AlertDialog.Builder(this,Resource.Style.AppCompatAlertDialogStyle);
                alertDialog.SetView(v);
                alertDialog.SetTitle("Öğrenci Ekleme Ekranı");

                alertDialog.SetPositiveButton("Ekle", delegate
                {
                    AddStudent(new Student
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = adTxt.Text,
                        Surname = soyadTxt.Text,
                        Grade = sinif
                    });
                    alertDialog.Dispose();
                });
                alertDialog.SetNegativeButton("İptal",delegate
                {
                    alertDialog.Dispose();
                });
                

                alertDialog.Show();
            }
            return base.OnOptionsItemSelected(item);
        }

        private void spinner_itemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = sender as Spinner;
            sinif = spinner.GetItemAtPosition(e.Position).ToString();
        }

        public async void AddStudent(Student model)
        {
            if (model.Name.Length>0 && model.Surname.Length>0 && model.Grade.Length>0)
            {
                try
                {
                    connection.AddStudent(model);
                    Toast.MakeText(this,"Kaydetme başarılı oldu.",ToastLength.Short).Show();
                    sinif = null;
                    ListeDoldur();
                }
                catch (Exception e)
                {
                    Toast.MakeText(this, "Hata! Mesaj:" + e.Message, ToastLength.Long);
                }
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}