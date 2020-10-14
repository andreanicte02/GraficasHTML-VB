##### Crear graficas, usando html en visual basic

Andrea Nicte Vicente Campos

Para uso de los industriales de la 092 xD

chale

F si no les gusta 

Solo crea archivos html y los js para que se puedan mostrar graficas en html

hace uso de la librería https://cdn.plot.ly/plotly-latest.min.js





```visual basic

'1argumento nombre del archivo
'2argumento titulo del reporte
'3argumento tipo de grafica
'tipo1 grafica de barras'
'tipo2 grafica de circulo'

Dim grafica As New Grafica("grafica", "reporte tal", 1)
'si es de barras'
'el primer argumento es el ejex'
'el segundo argumento es el ejey'
'si es de circulo'
'el primer argumento son los labels'
'el segundo argumento es el valor'
grafica.setEjes("oizza", "3")
grafica.setEjes("hola", "2.5")
grafica.setEjes("buneas", "5")
'se crea'
grafica.create()
'si esta en windows se abre, si no solo crean los archivos y los buscas a patita'
grafica.openInWIndows()

```

