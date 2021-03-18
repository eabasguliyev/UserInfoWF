using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace _180321Task
{
    public static class FileHelper
    {
        public static JsonSerializer Serializer;

        static FileHelper()
        {
            Serializer = new JsonSerializer();
        }
        public static void WriteToJson(string fileName, User user)
        {
            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        Serializer.Serialize(jw, user);
                    }
                }
            }
        }

        public static User ReadFromJson(string fileName)
        {
            User user = null;
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        using (var jr = new JsonTextReader(sr))
                        {

                            user = Serializer.Deserialize<User>(jr);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"There is no file associated this name: {fileName}");
            }

            return user;
        }
    }
    public static class ImageHelper
    {
        public static Byte[] ConvertImageToBytes(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            var bytes = ms.ToArray();

            return bytes;
        }

        public static Image ConvertBytesToImage(Byte[] bytes)
        {
            var imageMemoryStream = new MemoryStream(bytes);

            var image = Image.FromStream(imageMemoryStream);

            return image;
        }
    }
}