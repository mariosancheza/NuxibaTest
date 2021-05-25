
--Que muestre los registros con tipo de llamada Cel LD durante el mes febrero
SELECT log.*
FROM LOG_DIAL log
INNER JOIN COSTOS c ON c.id_tipo_llamada = log.id_tipo_llamada
WHERE c.id_tipo_llamada = 3
AND log.fecha_llamada LIKE '2020-02%'

--Que indique el promedio de tiempo de dialogo de las llamadas con tipo Cel LD durante el mes de febrero
SELECT AVG(ALL log.tiempo_dialogo) promedio_tiempo
FROM LOG_DIAL log
INNER JOIN COSTOS c ON c.id_tipo_llamada = log.id_tipo_llamada
WHERE c.id_tipo_llamada = 3
AND log.fecha_llamada LIKE '2020-02%'

--Que muestre el número en minutos de dialogo (tomando tiempoDialogo que está en segundos) y el costo de todas las llamadas del mes de enero
SELECT CONVERT((log.tiempo_dialogo/60), SIGNED) Minutos,
CONVERT((log.tiempo_dialogo*c.costos/60), DECIMAL) Costo
FROM LOG_DIAL log
INNER JOIN COSTOS c ON c.id_tipo_llamada = log.id_tipo_llamada
WHERE log.fecha_llamada LIKE '2020-01%'
AND log.id_tipo_llamada NOT IN (4)
--Se quita el tipo_llamada 4 (llamada local) debido a que no es parte de la tabla original sugerida)