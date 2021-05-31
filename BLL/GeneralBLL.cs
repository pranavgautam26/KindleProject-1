using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GeneralBLL
    {
        GeneralDAO dao = new GeneralDAO();
        public GeneralDTO GetPostDetailPageItemsWithID(int ID)
        {
            GeneralDTO dto = new GeneralDTO();
            
            
            dto.PostDetail = dao.GetPostDetail(ID);
            return dto;
        }

        CategoryDAO categorydao = new CategoryDAO();
        public GeneralDTO GetCategoryPostList(string categoryName)
        {
            GeneralDTO dto = new GeneralDTO();
           
            
                List<CategoryDTO> categorylist = categorydao.GetCategories();
                int categoryID = 0;
                foreach (var item in categorylist)
                {
                    if (categoryName == SeoLink.GenerateUrl(item.CategoryName))
                    {
                        categoryID = item.ID;
                        dto.CategoryName = item.CategoryName;
                        break;


                    }
                }
                dto.CategoryPostList = dao.GetCategoryPostList(categoryID);


            

            return dto;
        }

        public GeneralDTO GetSearchPosts(string searchText)
        {
            GeneralDTO dto = new GeneralDTO();
            
            dto.CategoryPostList = dao.GetSearchPosts(searchText);
            dto.SearchText = searchText;
            return dto;
        }

        public GeneralDTO GetSearchcPosts(string searchText, string categoryName)
        {
            GeneralDTO dto = new GeneralDTO();
            int categoryID = 0;


            if (categoryName == "Electrician")
            {
                categoryID = 5;
            }
            else if (categoryName == "Doctor")
            {
                categoryID = 1;
            }
            else if(categoryName == "Engineer")
            {
                categoryID = 2;
            }
           
            dto.CategoryPostList = dao.GetSearchcPosts(categoryID,searchText);
            dto.SearchText1 = searchText;
            return dto;
        }

        public GeneralDTO GetSearchiPosts(string searchText2, string categoryNameI)
        {
            GeneralDTO dto = new GeneralDTO();
            int categoryID = 0;


            if (categoryNameI == "Electrician")
            {
                categoryID = 5;
            }
            else if (categoryNameI == "Doctor")
            {
                categoryID = 1;
            }
            else if (categoryNameI == "Engineer")
            {
                categoryID = 2;
            }

            dto.CategoryPostList = dao.GetSearchcPosts(categoryID, searchText2);
            dto.SearchText2 = searchText2;
            return dto;
        }
    }
}
