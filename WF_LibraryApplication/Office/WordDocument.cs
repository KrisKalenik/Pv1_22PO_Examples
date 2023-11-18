using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.Remoting.Messaging;
using System.Reflection;

namespace WF_LibraryApplication.Office
{
    internal class WordDocument
    {
        private object _missingObj = System.Reflection.Missing.Value;
        private object _truObj = true;
        private object _falseObj = false;
        private Word._Application _application;
        private Word._Document _document;
        private Object _templatePathObj;
        private Word.Range _currentRange;
        private Word.Table _table;

        private WordSelection _selection;

        public WordSelection Selection
        {
            get { return _selection; }
            set { throw new Exception("Selection is read only"); }
        }

        public static char NewLineChar { get { return (char)11; } }

        public WordDocument(bool startVisible)
        {
            _application = new Word.Application();
            try
            {
                _document =
                    _application.Documents.Add(ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj);
                _currentRange = _document.Content;
                _table = null;
                SetSelectionToBegin();
                Visible = startVisible;
            }
            catch(Exception ex)
            {
                Close();
                throw ex;
            }
        }

        public WordDocument() : this(false) { }

        public WordDocument(string templatePath, bool startVisible)
        {
            _application = new Word.Application();
            _templatePathObj = templatePath;
            try
            {
                _document = _application.Documents.Add(ref _templatePathObj, ref _missingObj, ref _missingObj, ref _missingObj);
                SetSelectionToBegin();
                Visible = startVisible;
            }
            catch(Exception ex)
            {
                Close();
                throw ex;
            }
        }

        public WordDocument(string templatePath) : this(templatePath, false) { }

        public bool Closed
        {
            get
            {
                return _application == null || _document == null;
            }
        }

        public bool Visible
        {
            get
            {
                if (Closed) throw new Exception("Document closed");
                return _application.Visible;
            }
            set
            {
                if (Closed) throw new Exception("Document closed");
                _application.Visible = value;
            }
        }

        public int PageCount
        {
            get
            {
                int pageCount = 0;
                Word.WdStatistic pageStatType = Word.WdStatistic.wdStatisticPages;
                pageCount = _document.ComputeStatistics(pageStatType, ref _missingObj);
                return pageCount;
            }
        }

        public void SetSelectionToBegin()
        {
            object start = 0;
            object end = 0;
            _currentRange = _document.Range(ref start, ref end);
            _selection = new WordSelection(_currentRange);
        }

        public void SetSelectionToText(string stringToFind)
        {
            Word.Range range = findRangeByString(stringToFind);
            if (range == null)
                throw new Exception("No matches");
            _currentRange = range;
            _selection = new WordSelection(range, false);

        }

        public void SetSelectionToText(string containerString, string stringToFind)
        {
            Word.Range containerRange = null;
            Word.Range range = null;

            containerRange = findRangeByString(containerString);
            if (containerRange != null)
                range = findRangeByString(containerRange, stringToFind);
            if(range != null)
            {
                _currentRange = range;
                _selection = new WordSelection(range, false);
            }
            else
            {
                throw new Exception("No matches");
            }

        }

        public void SetSelectionToBookmark(string bookmarkName)
        {
            SetSelectionToBookmark(bookmarkName, false);
        }

        public void SetSelectionToBookmark(string bookmarkName, bool isParagraph)
        {
            if (Closed) throw new Exception("Document Closed");
            Object bookmarkNameObj = bookmarkName;
            Word.Range range = null;
            try
            {
                range = _document.Bookmarks.get_Item(ref bookmarkNameObj).Range;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            _currentRange = range;
            _selection = new WordSelection(range, false);

        }

        public void SetSelectionToCell(int row, int column)
        {
            if (_table == null) throw new Exception("No Table");

            _currentRange = _table.Cell(row, column).Range;
            _selection = new WordSelection(_currentRange, false);
        }

        public void ReplaceAllStrings(string strToFind, string strToReplace)
        {
            if (Closed) throw new Exception("Document Closed");
            object strToFindObj = strToFind;
            object strToReplaceObj = strToReplace;
            Word.Range range;
            object replaceTypeObj = Word.WdReplace.wdReplaceAll;

            try
            {
                for(int i = 1; i<= _document.Sections.Count; i++)
                {
                    range = _document.Sections[i].Range;
                    Word.Find find = range.Find;
                    object[] wordFindParameters = new object[15] { strToFindObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, strToReplaceObj,
                    replaceTypeObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj};
                    find.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, find, wordFindParameters);
                    
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertParagraphAfter()
        {
            if (Closed) throw new Exception("Document Closed");
            Object collapseDirection = Word.WdCollapseDirection.wdCollapseEnd;
            try
            {
                _currentRange.Collapse(collapseDirection);
                _currentRange.InsertParagraphAfter();
                _selection = new WordSelection(_currentRange, false);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertParagraphAfter(string strToInsert)
        {
            InsertParagraphAfter();
            _selection.Text = strToInsert;
        }

        public void Close()
        {
            if (_document != null)
                _document.Close(ref _falseObj, ref _missingObj, ref _missingObj);
            _application.Quit(ref _missingObj, ref _missingObj, ref _missingObj);
            _document = null;
            _application = null;
        }

        public void Save(string pathToSave)
        {
            Object pathToSaveObj = pathToSave;
            _document.SaveAs(ref pathToSaveObj, Word.WdSaveFormat.wdFormatDocument,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj);
        }

        public void InsertFile(string pathToFile)
        {
            if (_currentRange == null) throw new Exception("No selection");
            _currentRange.InsertFile(pathToFile);
        }

        public void InsertPageAtEnd()
        {
            object what = Word.WdGoToItem.wdGoToLine;
            object which = Word.WdGoToDirection.wdGoToLast;
            Word.Range endRange = _document.GoTo(ref what, ref which, ref _missingObj, ref _missingObj);
            _currentRange = endRange;
            _selection = new WordSelection(endRange);

            int oldPagesCount = PageCount;
            while (oldPagesCount == PageCount)
                InsertParagraphAfter();
            InsertParagraphAfter();
        }

        public void InsertTable(int rows, int columns, BorderType borderType)
        {
            _table = _document.Tables.Add(_currentRange, rows, columns, ref _missingObj, ref _missingObj);
            switch(borderType)
            {
                case BorderType.None:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    break;
                case BorderType.Single:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    break;
                case BorderType.Double:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    break;
                default:
                    throw new Exception("Undefind style");
            }
        }

        public void InsertTable(int rows, int columns)
        {
            InsertTable(rows, columns, BorderType.Single);
        }

        public void SetColumnWidth(int column, int widthPixels)
        {
            if (_table == null) throw new Exception("No Table");
            _table.Columns[column].SetWidth(widthPixels, Word.WdRulerStyle.wdAdjustNone);
        }

        public void SelectTable(int table)
        {
            try
            {
                _table = _document.Tables[table];
            }
            catch(Exception ex)
            {
                throw ex;
            }
            _currentRange = _table.Range;
            _selection = new WordSelection(_table.Range, true, false);
        }

        public void AddRpwToTable()
        {
            _table.Rows.Add(ref _missingObj);
        }

        private Word.Range findRangeByString(string strToFind)
        {
            if (Closed) throw new Exception("Document Closed");
            object strToFindObj = strToFind;
            Word.Range range;
            bool rangeFound;

            for(int i = 1; i <= _document.Sections.Count; i++)
            {
                range = _document.Sections[i].Range;
                Word.Find find = range.Find;
                object[] wordFindParameters = new object[15] { strToFindObj, _missingObj, _missingObj, 
                    _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj};
                rangeFound = (bool)find.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, find, wordFindParameters);
                if (rangeFound) return range;
            }
            return null;
        }

        private Word.Range findRangeByString(Word.Range containerRange, string strToFind)
        {
            if (Closed) throw new Exception("Document Closed");
            object strToFindObj = strToFind;
            bool rangeFound;
            Word.Find find = containerRange.Find;
            object[] wordFindParameters = new object[15] { strToFindObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj};
            rangeFound = (bool)find.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, find, wordFindParameters);
            if (rangeFound) return containerRange;
            else return null;

        }

        public static void FillShowTemplate(string pathToTemplate, Action<WordDocument> fillWordDoc)
        {
            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);
                wordDoc.Visible = true;
                fillWordDoc(wordDoc);
            }
            catch(Exception ex)
            {
                if(wordDoc != null) wordDoc.Close();
                throw ex;
            }
        }

        public void FillShowTemplate(Action<WordDocument> fillWordDoc)
        {
            try
            {
                fillWordDoc(this);
            }
            catch (Exception ex)
            {
                if (this != null) this.Close();
                throw ex;
            }
            this.Visible = true;
        }
    }
}
