using System.Text;
using Data;

namespace CSVReaders
{
    public enum EnumFerryCompany{
        Unknown = -1,
        Shinnihon = 0,
        Seikan
    }


    public class HighwayCsvReader
    {
        public List<HighwayCsvFormatElement> ReadCsv(string path)
        {
            List<HighwayCsvFormatElement> retList = new List<HighwayCsvFormatElement>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.GetEncoding("shift_jis")))
            {
                bool isFirst = true;
                while (!reader.EndOfStream)
                {
                    int i=0;
                    string line = reader.ReadLine();
                    if (isFirst)
                    {
                        isFirst = !isFirst;
                        continue;
                    }
                    string[] values = line.Split(',');
                    HighwayCsvFormatElement element = new HighwayCsvFormatElement();
                    foreach (string value in values)
                    {
                        switch (i)
                        {
                            case 0:
                                element.StartDate = value;
                                break;
                            case 1:
                                element.StartTime = value;
                                break;
                            case 2:
                                element.EndDate = value;
                                break;
                            case 3:
                                element.EndTime = value;
                                break;
                            case 4:
                                element.StartICName = value;
                                break;
                            case 5:
                                element.EndICName = value;
                                break;
                            case 8:
                                element.Payment = Int32.Parse(value);
                                break;
                            case 10:
                                element.CarNo = Int16.Parse(value);
                                break;
                            case 11:
                                element.ETCNo = value.Substring(value.Length - 6, 6);
                                break;
                            default:
                                break;
                        }
                        i++;
                    }
                    retList.Add(element);
                }
            }
            return retList;
        }
    }

    public class FerryCsvReader
    {
        public List<FerryCsvFormatElement> ReadCsv(EnumFerryCompany id, string path)
        {
            List<FerryCsvFormatElement> retList = new List<FerryCsvFormatElement>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.GetEncoding("shift_jis")))
            {
                bool isFirst = true;
                int row = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (isFirst)
                    {
                        isFirst = !isFirst;
                        continue;
                    }
                    line = ConvertString(line);
                    string[] values = line.Split(',');
                    FerryCsvFormatElement element =
                     id == EnumFerryCompany.Shinnihon ? ParseShinnihon(values) :
                     id == EnumFerryCompany.Seikan ? ParseSeikan(values) :
                     null;
                    element.RowNo = ++row; 
                    retList.Add(element);
                }
            }
            return retList;
        }

        private string ConvertString(string value)
        {
            string ret = "";
            bool f = false;

            foreach (var c in value)
            {
                if ('"' == c){
                    f = !f; 
                }
                if (',' == c){
                    if (!f)
                    {
                        ret += c;
                    }
                }else{
                    if ('"' != c)
                        ret += c;                    
                }
            }
            return ret;
        }

        private FerryCsvFormatElement ParseShinnihon(string[] values)
        {
            int i = 0;
            FerryCsvFormatElement element = new FerryCsvFormatElement();
            foreach (string value in values)
            {
                switch (i)
                {
                    case 0:
                        element.BoardingDate = value;
                        break;
                    case 1:
                        element.SeaRroute = value.Substring(3, value.Length -  3);
                        break;
                    case 2:
                        element.CarNo = value;
                        break;
                    case 3:
                        element.CarLength = int.Parse(value);
                        break;
                    case 4:
                        element.Remarks1 = value;
                        break;
                    case 8:
                        element.Remarks2 = value;
                        break;
                    case 9:
                        element.BillAmountTotal = int.Parse(value);;
                        break;
                    default:
                        break;
                }
                i++;
            }
            return element;
        }
        private FerryCsvFormatElement ParseSeikan(string[] values)
        {
            int i = 0;           
            FerryCsvFormatElement element = new FerryCsvFormatElement();

            foreach (string value in values)
            {
                switch (i)
                {
                    case 1:
                        element.BoardingDate = value;
                        break;
                    case 2:
                        element.SeaRroute = value;
                        break;
                    case 9:
                        element.CarNo = value;
                        break;
                    case 10:
                        element.CarLength = int.Parse(value);
                        break;
                    case 6:
                        element.BillAmountTotal = int.Parse(value);
                        break;
                    case 11:
                        element.Remarks1 = value;
                        break;
                    case 12:
                        element.Remarks2 = value;
                        break;
                    default:
                        break;
                }
                i++;
            }
            return element;
        }
    }
}