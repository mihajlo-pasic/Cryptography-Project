using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kripto
{
    internal class Algoritmi
    {
        //Railfence
        public string Railfence(string plaintext, int rails)
        {
            plaintext = plaintext.ToUpper();
            StringBuilder[] fence = new StringBuilder[rails];
            for (int i = 0; i < rails; i++)
            {
                fence[i] = new StringBuilder();
            }

            int rail = 0;
            int direction = 1;

            foreach (char c in plaintext)
            {
                if (c == ' ') continue;
                fence[rail].Append(c);
                rail += direction;

                if (rail == rails - 1 || rail == 0)
                {
                    direction = -direction;
                }
            }

            StringBuilder ciphertext = new StringBuilder();
            foreach (StringBuilder railString in fence)
            {
                ciphertext.Append(railString);
            }

            return ciphertext.ToString();
        }
        
        //Myszkowski
        public string Myszkowski(string plaintext, string key)
        {
            int cols = key.Length;
            int rows = (int)Math.Ceiling((double)plaintext.Length / cols);

            char[,] matrix = new char[rows, cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (index < plaintext.Length)
                    {
                        matrix[i, j] = plaintext[index++];
                    }
                    else
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            Dictionary<char, List<int>> charIndices = GetCharIndices(key);
            StringBuilder encryptedText = new StringBuilder();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (charIndices.ContainsKey(c))
                {
                    if (charIndices[c].Count > 1)
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            foreach (int col in charIndices[c])
                            {
                                char currentChar = matrix[row, col];
                                if (currentChar != ' ')  // Preskoči prazne karaktere
                                {
                                    encryptedText.Append(currentChar);
                                }
                            }
                        }
                        continue;
                    }

                    foreach (int col in charIndices[c])
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            char currentChar = matrix[row, col];
                            if (currentChar != ' ')  // Preskoči prazne karaktere
                            {
                                encryptedText.Append(currentChar);
                            }
                        }
                    }
                }
            }

            return encryptedText.ToString();
        }

        private Dictionary<char, List<int>> GetCharIndices(string key)
        {
            Dictionary<char, List<int>> charIndices = new Dictionary<char, List<int>>();

            key = key.ToUpper();
            for (int i = 0; i < key.Length; i++)
            {
                char c = key[i];
                if (!charIndices.ContainsKey(c))
                {
                    charIndices[c] = new List<int>();
                }

                charIndices[c].Add(i);
            }

            return charIndices;
        }

        //PLAYFAIR
        private char[,] GenerateKeySquare(string key)
        {
            // Prepare a key square (5x5 matrix) based on the given key.
            key = key.ToUpper().Replace("J", "I"); // Convert to uppercase and replace J with I.
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string keyAlphabet = key + alphabet;

            // Remove duplicate characters from the key.
            string uniqueKeyAlphabet = new string(keyAlphabet.Distinct().ToArray());

            char[,] keySquare = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    keySquare[i, j] = uniqueKeyAlphabet[i * 5 + j];
                }
            }

            return keySquare;
        }

        private Tuple<int, int> GetPosition(char[,] keySquare, char letter)
        {
            // Get the position of a letter in the key square.
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keySquare[i, j] == letter)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }

            return null;
        }

        public string Playfair(string plaintext, string key)
        {
            char[,] keySquare = GenerateKeySquare(key);
            List<string> digraphs = new List<string>();
            plaintext = plaintext.ToUpper().Replace("J", "I").Replace(" ", string.Empty);

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                if (i == plaintext.Length - 1 || plaintext[i] == plaintext[i + 1])
                {
                    digraphs.Add(plaintext[i] + "X");
                    i--;
                }
                else
                {
                    digraphs.Add(plaintext.Substring(i, 2));
                }
            }

            string ciphertext = "";

            foreach (var digraph in digraphs)
            {
                Tuple<int, int> firstChar = GetPosition(keySquare, digraph[0]);
                Tuple<int, int> secondChar = GetPosition(keySquare, digraph[1]);

                if (firstChar.Item1 == secondChar.Item1)
                {
                    // Same row
                    ciphertext += keySquare[firstChar.Item1, (firstChar.Item2 + 1) % 5];
                    ciphertext += keySquare[secondChar.Item1, (secondChar.Item2 + 1) % 5];
                }
                else if (firstChar.Item2 == secondChar.Item2)
                {
                    // Same column
                    ciphertext += keySquare[(firstChar.Item1 + 1) % 5, firstChar.Item2];
                    ciphertext += keySquare[(secondChar.Item1 + 1) % 5, secondChar.Item2];
                }
                else
                {
                    // Form a rectangle
                    ciphertext += keySquare[firstChar.Item1, secondChar.Item2];
                    ciphertext += keySquare[secondChar.Item1, firstChar.Item2];
                }
            }

            return ciphertext;
        }
    }
}
