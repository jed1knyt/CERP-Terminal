using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CERPTerminal
{
    public static class CERP
    {
        public static int gUserID;
        public static string gUserName;
        public static int gRole;

        public static int GetSourceTerminal(int _terminalID)
        {
            switch (_terminalID)
            { 
                case 3:
                    return 2;
                case 5:
                    return 4;
                case 7:
                    return 6;
                case 9:
                    return 8;
                default:
                    return -1;
            }
        }

        public static int GetTerminalOut(int _terminalID)
        {
            switch (_terminalID)
            {
                case 3:
                    return 4;
                case 5:
                    return 6;
                case 7:
                    return 8;
                case 9:
                    return 10;
                default:
                    return -1;
            }
        }

        public static int GetTerminalStatusCode(int _terminalID)
        {
            switch (_terminalID)
            {
                case 3:
                    return 103;
                case 4:
                    return 104;
                case 5:
                    return 105;
                case 6:
                    return 106;
                case 7:
                    return 107;
                case 8:
                    return 108;
                case 9:
                    return 109;
                case 10:
                    return 110;
                default:
                    return -1;
            }
        }

        public static string[] GetTemplates(int _terminalID)
        {
            string[] items = new string[0];
            items = new string[6];
            items[0] = "Delivery from WAREHOUSE";
            items[1] = "";
            items[2] = "Defect A";
            items[3] = "Defect B";
            items[4] = "QA Sample";
            items[5] = "Manager's Sample";
            switch (_terminalID)
            { 
                case 3: // PP
                    items[1] = "Endorse to INK-FILLING";
                    break;
                case 5: // IF
                    items[1] = "Endorse to LSP";
                    break;
                case 7: // LSP
                    items[1] = "Endorse to PACKING";
                    break;
                case 9: // PK
                    items[1] = "Endorse to WAREHOUSE";
                    break;
            }            

            return items;
        }

        public static string GetTerminalRemarks(string _type, int _srcTerminalID)
        {
            if (_type == "IN")
            {
                switch (_srcTerminalID)
                {
                    case 2: // W/H
                        return "[ Delivery from W/H ]";
                    case 4: // Pre-prod
                        return "[ Endorsement from Pre-Production Line ]";
                    case 6: // Ink-fill
                        return "[ Endorsement from Ink-Filling Line ]";
                    case 8: // LSP
                        return "[ Endorsement from LSP Line ]";
                    case 10: // Pack
                        return "[ Endorsement from Packing Line ]";
                    default:
                        return "[  ]";
                }
            }
            else
            {
                switch (_srcTerminalID)
                {
                    case 4:
                        return "[ Endorse to Pre-Production Line ]";
                    case 6:
                        return "[ Endorse to Ink-Filling Line ]";
                    case 8:
                        return "[ Endorse to PreLSP Line ]";
                    case 10:
                        return "[ Endorse to Packing Line ]";
                    default:
                        return "[  ]";
                }
            }            
        }

        public static Dictionary<int, string> GetProductionTerminals()
        {
            Dictionary<int, string> terminals = new Dictionary<int, string>();
            terminals.Add(3, "PRE-PRODUCTION LINE");
            terminals.Add(5, "INK FILLING LINE");
            terminals.Add(7, "LSP LINE");
            terminals.Add(9, "PACKING LINE");

            return terminals;
        }

        public static Dictionary<int, string> GetSourceTerminals(int _terminalID)
        {
            Dictionary<int, string> terminals = new Dictionary<int, string>();

            switch (_terminalID)
            { 
                case 3:
                    terminals.Add(2, "WAREHOUSE");
                    break;
                case 5:
                    terminals.Add(2, "WAREHOUSE");
                    terminals.Add(4, "PRE-PRODUCTION LINE");
                    break;
                case 7:
                    terminals.Add(2, "WAREHOUSE");
                    terminals.Add(6, "INK FILLING LINE");
                    break;
                case 9:
                    terminals.Add(2, "WAREHOUSE");
                    terminals.Add(8, "LSP LINE");
                    break;
            }
            return terminals;
        }

        public static Dictionary<int, string> GetOutBound(int _terminalID)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();

            switch (_terminalID)
            {
                case 3:
                    items.Add(104, "Endorse to Ink-Filling");
                    break;
                case 5:
                    items.Add(106, "Endorse to LSP");
                    break;
                case 7:
                    items.Add(108, "Endorse to Packing");
                    break;
                case 9:
                    items.Add(110, "Endorse to Warehouse 2");
                    break;
            }
            items.Add(96, "DEFECT A");
            items.Add(97, "DEFECT B");
            items.Add(98, "QA SAMPLE");
            items.Add(99, "MANAGER SAMPLE");

            return items;
        }

        
    }

    public static class CERPProperties
    {
        private static int _itemID;
        public static int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        private static string _itemCode;
        public static string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        private static string _description;
        public static string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private static int _prodTerminalID;
        public static int ProdTerminalID
        {
            get { return _prodTerminalID; }
            set { _prodTerminalID = value; }
        }

        private static string _oum;
        public static string UOM
        {
            get { return _oum; }
            set { _oum = value; }
        }

        private static int _terminalID;
        public static int TerminalID
        {
            get { return _terminalID; }
            set { _terminalID = value; }
        }

        private static string _terminalName;
        public static string TerminalName
        {
            get { return _terminalName; }
            set { _terminalName = value; }
        }

        private static int _srcTerminalID;
        public static int SrcTerminalID
        {
            get { return _srcTerminalID; }
            set { _srcTerminalID = value; }
        }
    }

    
}
