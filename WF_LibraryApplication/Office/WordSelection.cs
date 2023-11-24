using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace WF_LibraryApplication.Office
{
    public enum TextAligment { Left, Center, Right, Justify }
    public enum BorderType { None, Single, Double }
    internal class WordSelection
    {
        private Word.Range _currentRange;
        private bool _insertParAfterText = true;
        private Word.WdParagraphAlignment _savedAligment;

        public WordSelection(Word.Range inputRange) : this(inputRange, true)
        {

        }

        public WordSelection(Word.Range inputRange, bool insertParAfterText) : this(inputRange, insertParAfterText, true)
        {

        }

        public WordSelection(Word.Range inputRange, bool insertParAfterText, bool setDefaultStyle)
        {
            _currentRange = inputRange;
            _insertParAfterText = insertParAfterText;

            if (setDefaultStyle)
            {
                _currentRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                _savedAligment = _currentRange.ParagraphFormat.Alignment;
                _currentRange.Italic = 0;
                _currentRange.Bold = 0;
            }
            else
            {
                _savedAligment = _currentRange.ParagraphFormat.Alignment;
            }
        }

        public TextAligment Aligment
        {
            set
            {
                if (value == TextAligment.Left)
                    _currentRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                else if (value == TextAligment.Right)
                    _currentRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                else if (value == TextAligment.Center)
                    _currentRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                else if (value == TextAligment.Justify)
                    _currentRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                else throw new Exception("Unknown type of text aligment");
                _savedAligment = _currentRange.ParagraphFormat.Alignment;
            }
            get
            {
                if (_currentRange.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphLeft)
                    return TextAligment.Left;
                if (_currentRange.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphRight)
                    return TextAligment.Right;
                if (_currentRange.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphCenter)
                    return TextAligment.Center;
                if (_currentRange.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphJustify)
                    return TextAligment.Justify;
                else throw new Exception("Unknown type of text aligment");
            }
        }

        public BorderType Border
        {
            set
            {
                switch(value)
                {
                    case BorderType.None:
                        _currentRange.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                        break;
                    case BorderType.Single:
                        _currentRange.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        break;
                    case BorderType.Double:
                        _currentRange.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                        break;
                    default:
                        throw new Exception("Unknown type of Border style");
                }
            }

            get
            {
                switch(_currentRange.Borders.OutsideLineStyle)
                {
                    case Word.WdLineStyle.wdLineStyleNone:
                        return BorderType.None;
                    case Word.WdLineStyle.wdLineStyleSingle:
                        return BorderType.Single;
                    case Word.WdLineStyle.wdLineStyleDouble:
                        return BorderType.Double;
                    default:
                        throw new Exception("Unknown type of Border style");
                }
            }
        }

        public bool Bold
        {
            get => _currentRange.Bold == 1;
            set => _currentRange.Bold = value ? 1 : 0;
        }

        public bool Italic
        {
            get => _currentRange.Italic == 1;
            set => _currentRange.Italic = value ? 1 : 0;
        }

        public int FontSize
        {
            get => (int)_currentRange.Font.Size;
            set
            {
                if (value < 10)
                    throw new Exception("Error with Font size");
                _currentRange.Font.Size = value;
            }
        }

        public string Text
        {
            get => _currentRange.Text;
            set
            {
                _currentRange.Text = value;
                if (_insertParAfterText)
                    _currentRange.InsertParagraphAfter();
                _currentRange.ParagraphFormat.Alignment = _savedAligment;
            }
        }

        public void InsertHyperlink(string link, string text)
        {
            _currentRange.Hyperlinks.Add(_currentRange, link, null, text, null);
        }

        public void ApplyListStyle()
        {
            _currentRange.ListFormat.ApplyBulletDefault();
        }



    }
}
