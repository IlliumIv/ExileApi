cd ..\PoeHelper
del PoeHelper.7z
del PoeHelper.7z.*
"C:\Program Files\7-Zip\7z.exe" u -x@..\ExileApi\archive_exclude.txt PoeHelper.7z *
exit