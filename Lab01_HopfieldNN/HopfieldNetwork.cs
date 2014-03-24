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

                for (var i = 0; i < noiseVector.Length; i++)
                {
                    for (var j = 0; j < noiseVector.Length; j++)
                    {
                        resultVector[i] += (MatrixW[i, j] * noiseVector[j]);
                    }
                }

                var approximateVector = ApproximateSignum(resultVector);

                if (previousVector == null)
                {
                    var vectorNumber = SearchCorrectVector(approximateVector);

                    if (vectorNumber == -1)
                    {
                        previousVector = approximateVector;

                        var newNoiseVector = MakeAsyncChanges(noiseVector, approximateVector);

                        StartRecognize(newNoiseVector);
                    }
                    else
                    {
                        return vectorNumber;
                    }
                }
                else
                {
                    var result = CompareVectors(approximateVector, previousVector);

                    if (result == false)
                    {
                        previousVector = approximateVector;

                        var newNoiseVector = MakeAsyncChanges(noiseVector, approximateVector);

                        if (NumberOfIterantions > 200)
                        {
                            throw new StackOverflowException("Too many iterations");
                        }

                        StartRecognize(newNoiseVector);
                    }
                    else
                    {
                        var correctVector = SearchCorrectVector(approximateVector);

                        return correctVector;
                    }
                }
            }

            return -1;
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
        /// <returns></returns>
        private sbyte[] MakeAsyncChanges(sbyte[] noiseVector, sbyte[] approximateVector)
        {
            var neuronNumber = random.Next(0, approximateVector.Length);

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
    }
}
