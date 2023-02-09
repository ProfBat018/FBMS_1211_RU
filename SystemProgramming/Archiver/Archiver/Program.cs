using System;

namespace Archiver;


class Program
{
    // public static void Zip(string FileRes, string FileDest)
    // {
    //     FileStream? fs = null; 
    //     FileStream? rs = null;
    //     try
    //     {
    //         if (File.Exists(FileDest))
    //             File.Delete(FileDest);
    //         var format = FileRes.Substring(FileRes.LastIndexOf('.') + 1); 
    //         fs = new FileStream(FileRes, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
    //         rs = new FileStream(FileDest, FileMode.CreateNew);
    //         rs.WriteByte((byte)format.Length);
    //         
    //         foreach (var t in format)
    //             rs.WriteByte((byte)t);
    //
    //         var Bt = new List<byte>();
    //         var nBt = new List<byte>();
    //         while (fs.Position < fs.Length)
    //         {
    //             byte B = (byte)fs.ReadByte();
    //             if (Bt.Count == 0)
    //                 Bt.Add(B);
    //             else if (Bt[Bt.Count - 1] != B)
    //             {
    //                 Bt.Add(B);
    //                 if (Bt.Count == 255)
    //                 {
    //                     rs.WriteByte((byte)0);
    //                     rs.WriteByte((byte)255);
    //                     rs.Write(Bt.ToArray(), 0, 255);
    //                     Bt.Clear();
    //                 }
    //             }
    //             else
    //             {
    //                 if (Bt.Count != 1)
    //                 {
    //                     rs.WriteByte((byte)0);
    //                     rs.WriteByte((byte)(Bt.Count - 1));
    //                     rs.Write(Bt.ToArray(), 0, Bt.Count - 1);
    //                     Bt.RemoveRange(0, Bt.Count - 1);
    //                 }
    //                 Bt.Add(B);
    //                 while ((B = (byte)fs.ReadByte()) == Bt[0])
    //                 {
    //                     Bt.Add(B);
    //                     if (Bt.Count == 255)
    //                     {
    //                         rs.WriteByte((byte)255);
    //                         rs.WriteByte(Bt[0]);
    //                         Bt.Clear();
    //                         break;
    //                     }
    //                 }
    //                 if (Bt.Count > 0)
    //                 {
    //                     rs.WriteByte((byte)Bt.Count);
    //                     rs.WriteByte(Bt[0]);
    //                     Bt.Clear();
    //                     Bt.Add(B);
    //                 }
    //             }
    //         }
    //         if (Bt.Count > 0)
    //         {
    //             rs.WriteByte((byte)0);
    //             rs.WriteByte((byte)Bt.Count);
    //             rs.Write(Bt.ToArray(), 0, Bt.Count);
    //         }
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }
    //     finally
    //     {
    //         fs?.Close();
    //         rs?.Close();
    //     }
    // }

    public static void Zip(string FileRes, string FileDest)
    {
        FileStream fs = null; //исходный файл
        FileStream rs = null; //архив
        try
        {
            if (File.Exists(FileDest))
                File.Delete(FileDest);
            string Format = FileRes.Substring(FileRes.LastIndexOf('.') + 1); //получаем формат файла
            fs = new FileStream(FileRes, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            rs = new FileStream(FileDest, FileMode.CreateNew);
            //сначала сохраним формат исходного файла
            rs.WriteByte((byte)Format.Length);
            for (int i = 0; i < Format.Length; ++i)
                rs.WriteByte((byte)Format[i]);

            List<byte> Bt = new List<byte>();
            List<byte> nBt = new List<byte>();
            while (fs.Position < fs.Length)
            {
                byte B = (byte)fs.ReadByte();
                if (Bt.Count == 0)
                    Bt.Add(B);
                else if (Bt[Bt.Count - 1] != B)
                {
                    //неповторяющиеся байты
                    Bt.Add(B);
                    if (Bt.Count == 255)
                    {
                        rs.WriteByte((byte)0);
                        rs.WriteByte((byte)255);
                        rs.Write(Bt.ToArray(), 0, 255);
                        Bt.Clear();
                    }
                }
                else
                {
                    //повтор
                    if (Bt.Count != 1)
                    {
                        //в буфере могут быть неповторяющиеся байты
                        //их нужно сохранить
                        rs.WriteByte((byte)0);
                        rs.WriteByte((byte)(Bt.Count - 1));
                        rs.Write(Bt.ToArray(), 0, Bt.Count - 1);
                        Bt.RemoveRange(0, Bt.Count - 1);
                    }
                    Bt.Add(B);
                    while ((B = (byte)fs.ReadByte()) == Bt[0])
                    {
                        //пока идут повторы сохраняем их в буфер
                        Bt.Add(B);
                        if (Bt.Count == 255)
                        {
                            rs.WriteByte((byte)255);
                            rs.WriteByte(Bt[0]);
                            Bt.Clear();
                            break;
                        }
                    }
                    if (Bt.Count > 0)
                    {
                        //если в буфере что-то есть, сохраняем это
                        rs.WriteByte((byte)Bt.Count);
                        rs.WriteByte(Bt[0]);
                        Bt.Clear();
                        Bt.Add(B);
                    }
                }
            }
            if (Bt.Count > 0)
            {
                //после просмотра файла у нас может быть буфер с неповторяющимися байтами
                rs.WriteByte((byte)0);
                rs.WriteByte((byte)Bt.Count);
                rs.Write(Bt.ToArray(), 0, Bt.Count);
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (fs != null) fs.Close();
            if (rs != null) rs.Close();
        }
    }

   
    public static void Main()
    {
        Zip("Data.txt", "Data.txt");
    }
}