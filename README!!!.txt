Program domy�lnie przyjmuje na
wej�ciu plik input.xml (plik w formacie XML znajdujacy sie w folderze bin/debug),
oraz domy�lnie zwraca na wyj�ciu plik output.json 
(plik w formacie JSON).

Program jest zaprojektowany pod k�tem ochrony przed podstawowymi b��dami w dokumencie XML.
Przyj��em obiekt za poprawny gdy:
-posiada wspierane s�owa kluczowe(object, obj_name, field, name, type, value)
-ka�dy obiekt posiada przynajmniej jedno pole(obj_name || field)
-type moze byc tylko string lub int
-pole(field) musi posiada� nazwe, typ, wartosc.(name, type, value)
-posiada poprawne pola i znaczniki (okre�lone wy�ej).

Reszta na etapie analizowania dokumentu, jest pomijana.