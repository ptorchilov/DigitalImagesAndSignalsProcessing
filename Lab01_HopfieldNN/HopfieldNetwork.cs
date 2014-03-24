// -----------------------------------------------------------------------
// <copyright file="HopfieldNetwork.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Lab01_HopfieldNN
{
    /// <summary>
    /// Class for Hopfield network
    /// </summary>
    public class HopfieldNetwork
    {
        /// <summary>
        /// Gets or sets the matrix of coefficients.
        /// </summary>
        /// <value>
        /// The matrix of coefficients.
        /// </value>
        public static sbyte[,] MatrixW { get; set; }

        /// <summary>
        /// The previous vector
        /// </summary>
        private sbyte[] previousVector;

        /// <summary>
        /// The random
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Gets the correct vector.
        /// </summary>
        /// <value>
        /// The correct vector.
        /// </value>
        public sbyte CorrectVector { get; private set; }

        /// <summary>
        /// The number of iterantions
        /// </summary>
        public byte NumberOfIterantions { get; private set; }

        /// <summary>
        /// Starts the recognize.
        /// </summary>
        /// <param name="noiseVector">The noise vector.</param>
        /// <returns></returns>
        /// <exception cref="System.StackOverflowException">So many iterations</exception>
        public sbyte StartRecognize(sbyte[] noiseVector)
        {
            NumberOfIterantions++;

            if (MatrixW != null)
            {
                var resultVector = new int[noiseVector.Length];

                CopyArray(noiseVector,  ref resultVector);

                var neuronNumber = random.Next(0, noiseVector.Length);

                resultVector[neuronNumber] = 0;

                for (var i = 0; i < noiseVector.Length; i++)
                {
                    resultVector[neuronNumber] += (MatrixW[neuronNumber, i] * noiseVector[i]);
                }

                var approximateVector = ApproximateSignum(resultVector);

                if (previousVector == null)
                {
                    var vectorNumber = SearchCorrectVector(approximateVector);

                    if (vectorNumber == -1)
                    {
                        previousVector = approximateVector;

                        var newNoiseVector = MakeAsyncChanges(noiseVector, approximateVector, neuronNumber);

                        StartRecognize(newNoiseVector);
                    }
                    else
                    {
                        CorrectVector = vectorNumber;
                    }
                }
                else
                {
                    var result = CompareVectors(approximateVector, previousVector);

                    if (result == false)
                    {
                        previousVector = approximateVector;

                        var newNoiseVector = MakeAsyncChanges(noiseVector, approximateVector, neuronNumber);

                        if (NumberOfIterantions > 1000)
                        {
                            CorrectVector = -1;
                        }

                        StartRecognize(newNoiseVector);
                    }
                    else
                    {
                        var correctVector = SearchCorrectVector(approximateVector);

                        if (correctVector == -1)
                        {
                            previousVector = approximateVector;

                            var newNoiseVector = MakeAsyncChanges(noiseVector, approximateVector, neuronNumber);

                            if (NumberOfIterantions > 1000)
                            {
                                CorrectVector = -1;
                            }

                            StartRecognize(newNoiseVector); 
                        }
                        else
                        {
                            CorrectVector = correctVector;
                        }
                    }
                }
            }

            return -2;
        }

        /// <summary>
        /// Approximates the signum.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns></returns>
        private sbyte[] ApproximateSignum(int[] vector)
        {
            var result = new sbyte[vector.Length];

            for (var i = 0; i < vector.Length; i++)
            {
                if (vector[i] >= 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = -1;
                }
            }

            return result;
        }

        /// <summary>
        /// Compares the vectors.
        /// </summary>
        /// <param name="firstVector">The first vector.</param>
        /// <param name="secondVector">The second vector.</param>
        /// <returns></returns>
        private bool CompareVectors(sbyte[] firstVector, sbyte[] secondVector)
        {
            var result = true;

            for (var i = 0; i < firstVector.Length; i++)
            {
                if (firstVector[i] != secondVector[i])
                {
                    result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// Makes the asynchronous changes.
        /// </summary>
        /// <param name="noiseVector">The noise vector.</param>
        /// <param name="approximateVector">The approximate vector.</param>
        /// <param name="neuronNumber">The neuron number.</param>
        /// <returns></returns>
        private sbyte[] MakeAsyncChanges(sbyte[] noiseVector, sbyte[] approximateVector, int neuronNumber)
        {
            noiseVector[neuronNumber] = approximateVector[neuronNumber];

            return noiseVector;
        }

        /// <summary>
        /// Searches the correct vector.
        /// </summary>
        /// <param name="noiseVector">The noise vector.</param>
        /// <returns></returns>
        private sbyte SearchCorrectVector(sbyte[] noiseVector)
        {
            sbyte result = -1;

            if (CompareVectors(noiseVector, NeuronHelper.VectorA))
            {
                result = 0;
            }
            else if (CompareVectors(noiseVector, NeuronHelper.VectorB))
            {
                result = 1;
            } else if (CompareVectors(noiseVector, NeuronHelper.VectorC))
            {
                result = 2;
            }

            return result;
        }

        /// <summary>
        /// Copies the array.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="target">The target.</param>
        private void CopyArray(sbyte[] source, ref int[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            } 
        }
    }
}
