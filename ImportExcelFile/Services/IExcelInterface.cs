using ImportExcelFile.Models;

namespace ImportExcelFile.Services
{
    public interface IExcelInterface
    {
        MemoryStream LerStream(IFormFile formFile);
        List<ImportExcelFileTableModel> LerXls(MemoryStream stream);
        void SalvarDados(List<ImportExcelFileTableModel> produtos);
    }
}
