using Add.ons.Web.Models;

namespace Add.ons.Web.Services
{
    public class AplikasiService : IAplikasiService
    {
        private const string FILE_NAME = "_databases.txt";
        public async Task<List<AplikasiViewModel>> Read() 
        {
             if(!File.Exists(System.AppContext.BaseDirectory + FILE_NAME)){
                return new List<AplikasiViewModel>();
            }
            var res = await File.ReadAllLinesAsync(System.AppContext.BaseDirectory + FILE_NAME);
            if(res == null)
                return new List<AplikasiViewModel>();

            List<AplikasiViewModel> aplikasi = new List<AplikasiViewModel>();
            foreach (var item in res)
            {
                var dataSplit = item.Split(";").ToArray();
                aplikasi.Add(new AplikasiViewModel(int.Parse(dataSplit[0]), dataSplit[1], dataSplit[2], int.Parse(dataSplit[3])));
            }

            return aplikasi;
        }

        public async Task Write(Aplikasi request)
        {
            if(!File.Exists(System.AppContext.BaseDirectory + FILE_NAME)){
                using (var fileStream = File.Create(System.AppContext.BaseDirectory + FILE_NAME)){
                    fileStream.Close();
                }
            }
            using(var fileStream = File.AppendText(System.AppContext.BaseDirectory + FILE_NAME)){
                await fileStream.WriteLineAsync($"{request.Id};{request.Title};{request.Desc};{request.TotalLike}");
            }
        }
    }
}