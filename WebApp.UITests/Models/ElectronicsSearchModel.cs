using TechTalk.SpecFlow.Assist.Attributes;

namespace WebApp.UITests.Models
{
    public class ElectronicsSearchModel
    {
        [TableAliases("Искомое слово или фраза")]
        public string Phrase { get; set; }
        [TableAliases("Цена min")]
        public string PriceMin { get; set; }
        [TableAliases("Цена max")]      
        public string PriceMax { get; set; }
        [TableAliases("Подрубрика")]
        public string TransactionType { get; set; }
        [TableAliases("Город, район")]
        public string Region { get; set; }
        [TableAliases("Искать за период")]
        public string Period { get; set; }
        [TableAliases("Сортировать по")]
        public string SortBy { get; set; }
    }
}
