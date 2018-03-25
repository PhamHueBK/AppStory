using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.FormParagraphModel;

namespace Project.ViewModel.FormParagraphViewModel
{
    public class ParagraphViewModel
    {
        public List<ParagraphModel> listDoan;

        public string search;
        public string[] keywords;//Khi nguoi

        public void getData(long pathId)
        {
            /*Lay ra danh sach cac doan cua pathId*/

            this.listDoan = rs;
        }

        public List<ParagraphModel> searchRS()
        {
            this.search = "";
            this.keywords = this.search.Split(new Char[] { ' ' });

            /*Tim kiem*/

            List<ParagraphModel> rs = new List<ParagraphModel>();
            
            return rs;
        }
    }
}
