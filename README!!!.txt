Program domyœlnie przyjmuje na
wejœciu plik input.xml (plik w formacie XML znajdujacy sie w folderze bin/debug),
oraz domyœlnie zwraca na wyjœciu plik output.json 
(plik w formacie JSON).

Program jest zaprojektowany pod k¹tem ochrony przed podstawowymi b³êdami w dokumencie XML.
Przyj¹³em obiekt za poprawny gdy:
-posiada wspierane s³owa kluczowe(object, obj_name, field, name, type, value)
-ka¿dy obiekt posiada przynajmniej jedno pole(obj_name || field)
-type moze byc tylko string lub int
-pole(field) musi posiadaæ nazwe, typ, wartosc.(name, type, value)
-posiada poprawne pola i znaczniki (okreœlone wy¿ej).

Reszta na etapie analizowania dokumentu, jest pomijana.