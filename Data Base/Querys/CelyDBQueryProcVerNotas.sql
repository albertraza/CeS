use [CelyDB]
go
alter Proc VerReporteNotas
(
@matricula int,
@Fecha date
)
as
Select NotasExamenEscrito.Matricula, NotasExamenEscrito.Nombre, NotasExamenEscrito.N1 as [PrimerparcialEscr], NotasExamenEscrito.N2 as [SegundoParcialEscr], NotasExamenEscrito.N3 as [TercelParcialEscr], NotasExamenEscrito.NF as [NotaFinalEscr], NotasExamenEscrito.Fecha_Examen,
NotasExamenLectura.N1 as [PrimerParcialLect], NotasExamenLectura.N2 as [SegundoParcialLect], NotasExamenLectura.N3 as [TercelParcialLect], NotasExamenLectura.NF as [NotaFinalLect], NotasExamenLectura.Fecha_Examen,
NotasExamenOral.N1 as [PrimerParcialOral], NotasExamenOral.N2 as [SegundoParcialOral], NotasExamenOral.N3 as [TercelParcialOral], NotasExamenOral.NF as [NotaFinalOral], NotasExamenOral.Fecha_Examen,
NotasExposicion.N1 as [PrimeraExposicion], NotasExposicion.N2 as [SegundaExposicion], NotasExposicion.N3 as [TerceraExposicion], NotasExposicion.NF as [NotaFinalExp], NotasExposicion.Fecha_Examen from NotasExposicion, NotasExamenEscrito, NotasExamenLectura, NotasExamenOral where
NotasExamenEscrito.Matricula = @matricula and NotasExamenLectura.Matricula = @matricula and NotasExamenOral.Matricula = @matricula  and NotasExposicion.Matricula = @matricula and NotasExamenEscrito.Fecha_Examen = @Fecha and NotasExamenLectura.Fecha_Examen = @Fecha and NotasExamenOral.Fecha_Examen = @Fecha and NotasExposicion.Fecha_Examen = @Fecha


execute VerReporteNotas '11028', '2015-10-23'
