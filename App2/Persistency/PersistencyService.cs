using App2.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;

namespace App2.Persistency
{
    public class PersistencyService
    { 
                   private static string JsonFileName = "RegisterInfoAsJson.dat";
            
            public static void SaveRegisterInfoAsJsonAsync(ObservableCollection<RegisterModel> RegisterInfo)
            {
                string RegisterInfoJsonString = JsonConvert.SerializeObject(RegisterInfo);
                SerializeRegisterInfoFileAsync(RegisterInfoJsonString, JsonFileName);
            }

            public static async Task<List<RegisterModel>> LoadRegisterInfoAsJsonAsync()
            {
                string RegisterInfoJsonString = await DeserializeRegisterInfoFileAsync(JsonFileName);
                if (RegisterInfoJsonString != null)
                {
                    return (List<RegisterModel>)JsonConvert.DeserializeObject(RegisterInfoJsonString, typeof(List<RegisterModel>));
                }
                return null;
            }

            private static async void SerializeRegisterInfoFileAsync(string RegisterInfoJsonString, string fileName)
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
                await FileIO.WriteTextAsync(localFile, RegisterInfoJsonString);
            }


            private static async Task<string> DeserializeRegisterInfoFileAsync(string fileName)
            {
                try
                {
                    StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                    return await FileIO.ReadTextAsync(localFile);
                }
                catch (FileNotFoundException ex)
                {
                    MessageDialogHelper.Show("Loading for the first time? - Try to Add and Save some Notes before trying to Save for the first time", "File not Found");
                    return null;
                }
            }
            private class MessageDialogHelper
            {
                public static async void Show(string content, string title)
                {
                    MessageDialog messageDialog = new MessageDialog(content, title);
                    await messageDialog.ShowAsync();
                }
            }
        }
    }




