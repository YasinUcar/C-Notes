#region Klasördeki dosyaları okumak yazdırmak
List<FileInfo> files = DosyaYazdir("D:\\Yedek");
foreach (FileInfo file in files)
{
    Console.WriteLine(file.FullName);
}
List<FileInfo> DosyaYazdir(string path)
{
    List<FileInfo> fileInfos = new();
    DirectoryInfo directoryInfo = new(path);
    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
    // for (int i = 0; i < directoryInfos.Count(); i++)
    // {
    //     Console.WriteLine(directoryInfos[i]); //bu verdiğimiz dosyanın ana dizinlerini alır alt dizinlere ulaşmak için recursive kullanabiliriz
    // }
    if (directoryInfos.Any())
    {
        foreach (DirectoryInfo directory in directoryInfos)
        {
            fileInfos.AddRange(DosyaYazdir(directory.FullName))//FullName özelliği ile FileInfo nesnesine yolu verilen dosyanın tam yoluna ulaşabiliriz.
        }
    }
    else
    {
        fileInfos.AddRange(directoryInfo.GetFiles());

    }
    return fileInfos;

}
#endregion