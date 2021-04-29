using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM
{
    public static class AcumuladorDeFrecuencias
    {

        public static List<Tuple<double, double, double, double>> crearTuplas(List<double> extremosInferiores, List<double> extremosSuperiores, List<double> frecObservadas, List<double> frecEsperadas)
        {
            Debug.Assert(extremosInferiores.Count == extremosSuperiores.Count);
            Debug.Assert(extremosInferiores.Count == frecEsperadas.Count);
            Debug.Assert(extremosInferiores.Count == frecObservadas.Count);

            List<Tuple<double, double, double, double>> lista = new List<Tuple<double, double, double, double>>();

            for (int i = 0; i < extremosInferiores.Count; i++)
            {
                lista.Add(Tuple.Create(extremosInferiores[i], extremosSuperiores[i], frecObservadas[i], frecEsperadas[i]));
            }

            return lista;
        }

        public static List<Tuple<double, double, double, double>> agrupar(int umbralMinimo, List<Tuple<double, double, double, double>> lista)
        {

            // Caso Base
            if (lista.Count == 1)
            {
                return lista;
            }
            else
            {
                // Suma la frecuencia de todos los elementos.
                double sumaElementos = lista.Sum(e => e.Item4);

                // Si la suma de frecuencias esperadas de TODA la lista no es mayor al umbral minimo, no se puede juntar ningun elemento, devolver la lista.
                if (sumaElementos < umbralMinimo)
                {
                    return lista;
                }
                else
                {
                    // Si NO existe algun elemento que su frecuenciaEsperada sea menor al umbral.
                    if (lista.Where(e => e.Item4 < umbralMinimo).ToList().Count == 0)
                    {
                        return lista;
                    }
                    else
                    {
                        // Existe algun elemento que su frecuenciaEsperada es menor al umbral.
                        // Buscar su indice
                        int indice = lista.Select((e, idx) => new { e, idx }).Where(p => p.e.Item4 < umbralMinimo).Select(p => p.idx).FirstOrDefault();

                        Tuple<double, double, double, double> elem1 = lista[indice];
                        Tuple<double, double, double, double> elem2 = new Tuple<double, double, double, double>(0.0, 0.0, 0.0, 0.0);
                        bool estoyEnElUltimoElemento = false;

                        // Si llego hasta el final de la lista..
                        if (indice + 1 == lista.Count)
                        {
                            estoyEnElUltimoElemento = true;
                            elem2 = elem1;
                            elem1 = lista[indice - 1];
                        }
                        else
                        {
                            elem2 = lista[indice + 1];
                        }

                        // Nueva tupla con los elementos sumados
                        Tuple<double, double, double, double> elemSumados = new Tuple<double, double, double, double>(elem1.Item1, elem2.Item2, elem1.Item3 + elem2.Item3, elem1.Item4 + elem2.Item4);

                        // Crear nueva lista
                        List<Tuple<double, double, double, double>> nuevaLista = new List<Tuple<double, double, double, double>>();

                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (i == indice)
                            {
                                // En el lugar del indice agregar la tupla sumada
                                nuevaLista.Add(elemSumados);
                            }
                            else if (i == indice + 1 && !estoyEnElUltimoElemento)
                            {
                                // Este elemento no se agrega
                            }
                            else if (i == indice - 1 && estoyEnElUltimoElemento)
                            {
                                // Este elemtno tampoco se agrega
                            }
                            else
                            {
                                // Agregar cualquier otro elemento en el array.
                                nuevaLista.Add(lista[i]);
                            }
                        }

                        // La nueva lista deberÃ­a ser menor a la lista principal
                        Debug.Assert(nuevaLista.Count < lista.Count);

                        return agrupar(umbralMinimo, nuevaLista);
                    }
                }
            }
        }

    }
}
