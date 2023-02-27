using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.GuidHelperr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Windows.Foundation;

namespace Core.Utilities.Helpers.FileHelper
{
   public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))
                {                           
                                            
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName);
                string guid = GuidHelperr.GuidHelper.CreateGuid();

                string filePath = guid + extension;

                using (FileStream fileStream = File.Create(root + filePath))//Burada en başta FileStrem class'ının bir örneği oluşturulu., sonrasında File.Create(root + newPath)=>Belirtilen yolda bir dosya oluşturur veya üzerine yazar. (root + newPath)=>Oluşturulacak dosyanın yolu ve adı.
                {
                    file.CopyTo(fileStream);//Kopyalanacak dosyanın kopyalanacağı akışı belirtti. yani yukarıda gelen IFromFile türündeki file dosyasınınnereye kopyalacağını söyledik.
                    fileStream.Flush();//arabellekten siler.
                    return filePath;//burada dosyamızın tam adını geri gönderiyoruz sebebide sql servere dosya eklenirken adı ile eklenmesi için.
                }
            }
            return null;
        }
    }
}
