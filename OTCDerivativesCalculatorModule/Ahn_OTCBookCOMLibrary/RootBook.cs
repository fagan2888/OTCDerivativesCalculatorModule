using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel_Interface;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class RootBook
    {
        private RootBookViewModel root_bvm;

        public RootBook()
        {
            SettingInitializer setting = new SettingInitializer();
            setting.initialze(1);
        }

        public string load()
        {
            try
            {
                if (this.root_bvm == null)
                {
                    this.root_bvm = new RootBookViewModel();
                }

                return "loaded";
            }
            catch (Exception e)
            {
                return "load Fail : " + e.Message;
            }
            
        }

        public string setReferenceDate(DateTime refDate)
        {
            try
            {
                RootBookViewModel.setRootBookReferenceDate(refDate);

                this.root_bvm.loadPosition();

                return "set and position loaded complete.";
            }
            catch (Exception e)
            {
                return "set Reference Fail : " + e.Message;
            }
            
        }

        public Book get_book(string bookName)
        {
            try
            {
                BookViewModel bvm = this.root_bvm.getBook(bookName);

                if (bvm.BookName_ == "nullBook")
                    throw new Exception(bookName + " : not found");

                Book book = new Book(bvm);

                return book;

            }
            catch (Exception e)
            {
                throw e;

                //BookViewModel bvm = new BookViewModel();

                //Book book = new Book(bvm);

                //return book;
            }
           
        }

        public string remove_book(string bookName)
        {
            try
            {
                BookViewModel bvm = this.root_bvm.getBook(bookName);

                if (bvm.BookName_ == "nullBook")
                    throw new Exception(bookName + " : not found");

                Book book = new Book(bvm);

                this.save_book();

                return "remove book complete " + bookName;

            }
            catch (Exception e)
            {
                throw e;

                //BookViewModel bvm = new BookViewModel();

                //Book book = new Book(bvm);

                //return book;
            }
        }

        public string bookList()
        {
            try
            {
                List<BookViewModel> bvmList = new List<BookViewModel>();

                //if (includeChildBook)
                //{
                //    foreach (var item in bvm_.ChildBookList_)
                //    {
                //        item.getBookList(bvmList);
                //    }
                //}

                foreach (var item in root_bvm.ChildBookList_)
                {
                    item.getBookList(bvmList);

                    //bvmList.Add(item);
                }

                StringBuilder sb = new StringBuilder();

                foreach (var item in bvmList)
                {
                    sb.Append(item.BookName_);
                    sb.Append("|");
                }
                
                return sb.ToString();
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }
        }

        public string[] bookListArr()
        {
            List<string> bookInfoList = new List<string>();

            try
            {
                List<BookViewModel> bvmList = new List<BookViewModel>();

                //if (includeChildBook)
                //{
                //    foreach (var item in bvm_.ChildBookList_)
                //    {
                //        item.getBookList(bvmList);
                //    }
                //}

                foreach (var item in root_bvm.ChildBookList_)
                {
                    item.getBookList(bvmList);
                }

                StringBuilder sb = new StringBuilder();

                foreach (var item in bvmList)
                {
                    bookInfoList.Add(item.BookName_);
                }

                return bookInfoList.ToArray<string>();
            }
            catch (Exception e)
            {
                bookInfoList.Add("booking fail : " + e.Message);

                return bookInfoList.ToArray<string>();
            }
        }

        public string save_book()
        {
            try
            {
                this.root_bvm.saveXml();

                return "book update complete";
            }
            catch (Exception e)
            {
                throw e;
            }
     
        }


    }
}
