# Xml--Json
Connverting xml to json using LINQ

Program domyślnie przyjmuje na
wejściu plik input.xml (plik w formacie XML znajdujacy sie w folderze bin/debug),
oraz domyślnie zwraca na wyjściu plik output.json 
(plik w formacie JSON).

Program jest zaprojektowany pod kątem ochrony przed podstawowymi błędami w dokumencie XML.
Przyjąłem obiekt za poprawny gdy:
-posiada wspierane słowa kluczowe(object, obj_name, field, name, type, value)
-każdy obiekt posiada przynajmniej jedno pole(obj_name || field)
-type moze byc tylko string lub int
-pole(field) musi posiadać nazwe, typ, wartosc.(name, type, value)
-posiada poprawne pola i znaczniki (określone wyżej).

Reszta na etapie analizowania dokumentu, jest pomijana.
