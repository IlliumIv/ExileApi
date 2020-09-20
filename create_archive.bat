cd ..\PoeHelper
del ExileCore.dll
del GameOffsets.dll
del PoeHelper.7z
del PoeHelper.7z.*
"C:\Program Files\7-Zip\7z.exe" u -x@..\ExileApi\archive_exclude.txt PoeHelper.7z *
copy ..\ExileApi\ExileCore.dll ExileCore.dll
copy ..\ExileApi\GameOffsets.dll GameOffsets.dll
exit