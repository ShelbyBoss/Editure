﻿using System.IO;
using System.Xml.Serialization;
using Editure.Backend.ViewModels;
using FolderFile;

namespace Editure.Backend.Save
{
    public class SaveClass
    {
        private const string configFileName = "Config.xml";
        private static readonly XmlSerializer ser = new XmlSerializer(typeof(SaveClass));

        public WindowInfo Window { get; set; }

        public SearchInfo Search { get; set; }
        
        public ChooseInfo Choose { get; set; }
        
        public EditInfo Edit { get; set; }
        
        public CopyInfo Copy { get; set; }
        
        public MixInfo Mix { get; set; }

        private SaveClass()
        {
            Window = new WindowInfo();

            Search = new SearchInfo();
            Choose = new ChooseInfo();
            Edit = new EditInfo();
            Copy = new CopyInfo();
            Mix = new MixInfo();
        }

        private SaveClass(ViewModel vm)
        {
            Window = new WindowInfo();
            Search = new SearchInfo();
            Choose = new ChooseInfo();
            Edit = new EditInfo();
            Copy = new CopyInfo();
            Mix = new MixInfo();


            Window.Width = vm.WindowWidth;
            Window.Height = vm.WindowHeight;
            Window.PositionX = vm.WindowLeft;
            Window.PositionY = vm.WindowTop;
            Window.Maximized = vm.WindowState == System.Windows.WindowState.Maximized;


            Search.Src = (SerializableFolder?)vm.Search.Src;
            Search.Ref = (SerializableFolder?)vm.Search.Ref;

            Search.SrcFound = vm.Search.SrcFound;
            Search.SrcNot = vm.Search.SrcNot;
            Search.RefFound = vm.Search.RefFound;

            Search.WithExtensions = vm.Search.IsWithExtension;


            Choose.Src = (SerializableFolder?)vm.Choose.Src;

            Choose.Have = vm.Choose.Have;
            Choose.Havent = vm.Choose.Havent;

            Choose.MinWidth = vm.Choose.Min.Width;
            Choose.MinHeight = vm.Choose.Min.Height;
            Choose.MaxWidth = vm.Choose.Max.Width;
            Choose.MaxHeight = vm.Choose.Max.Height;


            Edit.Src = (SerializableFolder?)vm.Edit.Src;
            Edit.DestPath = vm.Edit.Dest?.OriginalPath;

            Edit.FlipX = vm.Edit.IsFlipX;
            Edit.FlipY = vm.Edit.IsFlipY;

            Edit.Wanna = vm.Edit.Wanna;
            Edit.Offset = vm.Edit.Offset;

            Edit.Mode = vm.Edit.ModeType;
            Edit.ReferencePositionType = vm.Edit.ReferencePosition;
            Edit.EditEncoder = vm.Edit.EncoderType;


            Copy.Src = (SerializableFolder?)vm.Copy.Src;
            Copy.DestPath = vm.Copy.Dest?.OriginalPath;


            Mix.Folder = (SerializableFolder?)vm.Mix.Folder;
            Mix.Mix = vm.Mix.IsMix;
            Mix.Auto = vm.Mix.IsAuto;
        }

        public static ViewModel Load(string path = configFileName)
        {
            Folder folder;
            SaveClass sc = LoadSaveClass(path);
            ViewModel vm = new ViewModel
            {
                WindowWidth = sc.Window.Width,
                WindowHeight = sc.Window.Height,
                WindowLeft = sc.Window.PositionX,
                WindowTop = sc.Window.PositionY,
                WindowState = sc.Window.Maximized ? System.Windows.WindowState.Maximized : System.Windows.WindowState.Normal
            };

            if (Folder.TryCreate(sc.Search.Src, out folder)) vm.Search.Src = folder;
            if (Folder.TryCreate(sc.Search.Ref, out folder)) vm.Search.Ref = folder;

            vm.Search.SrcFound = sc.Search.SrcFound;
            vm.Search.SrcNot = sc.Search.SrcNot;
            vm.Search.RefFound = sc.Search.RefFound;

            vm.Search.IsWithExtension = sc.Search.WithExtensions;


            if (Folder.TryCreate(sc.Choose.Src, out folder)) vm.Choose.Src = folder;

            vm.Choose.Have = sc.Choose.Have;
            vm.Choose.Havent = sc.Choose.Havent;

            vm.Choose.Min = new IntSize(sc.Choose.MinWidth, sc.Choose.MinHeight);
            vm.Choose.Max = new IntSize(sc.Choose.MaxWidth, sc.Choose.MaxHeight);


            if (Folder.TryCreate(sc.Choose.Src, out folder)) vm.Choose.Src = folder;
            if (Folder.TryCreate(sc.Edit.Src, out folder)) vm.Edit.Src = folder;
            if (Folder.TryCreate(sc.Edit.DestPath, SubfolderType.This, out folder)) vm.Edit.Dest = folder;

            vm.Edit.IsFlipX = sc.Edit.FlipX;
            vm.Edit.IsFlipX = sc.Edit.FlipY;

            vm.Edit.Wanna = sc.Edit.Wanna;
            vm.Edit.Offset = sc.Edit.Offset;

            vm.Edit.ModeType = sc.Edit.Mode;
            vm.Edit.ReferencePosition = sc.Edit.ReferencePositionType;
            vm.Edit.EncoderType = sc.Edit.EditEncoder;


            if (Folder.TryCreate(sc.Copy.Src, out folder)) vm.Copy.Src = folder;
            if (Folder.TryCreate(sc.Copy.DestPath, SubfolderType.This, out folder)) vm.Copy.Dest = folder;


            if (Folder.TryCreate(sc.Mix.Folder, out folder)) vm.Mix.Folder = folder;

            vm.Mix.IsMix = sc.Mix.Mix;
            vm.Mix.IsAuto = sc.Mix.Auto;

            return vm;
        }

        private static SaveClass LoadSaveClass(string path)
        {
            try
            {
                using (Stream stream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    return (SaveClass)ser.Deserialize(stream);
                }
            }
            catch { }

            return new SaveClass();
        }

        public static void Save(ViewModel vm, string path = configFileName)
        {
            SaveClass saveClass = new SaveClass(vm);
            StreamWriter writer = new StreamWriter(path);

            ser.Serialize(writer, saveClass);
            writer.Close();
        }
    }
}
