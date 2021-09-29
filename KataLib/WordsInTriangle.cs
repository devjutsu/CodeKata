using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class WordsInTriangle
    {
        public string[] GetWordInTriangle(string[] words)
        {
            var maxLengthElement = words.Select((w, i) => new { Word = w, Index = i })
                                .OrderByDescending(o => o.Word.Length)
                                .FirstOrDefault();

            var maxWidthNeeded = (maxLengthElement?.Word.Length ?? 0) + 2;
            maxWidthNeeded += maxWidthNeeded % 2 == 0 ? 1 : 0;
            var levelsAfterMax = words.Length - (maxLengthElement?.Index ?? 0) - 1;

            var levelForMax = maxWidthNeeded / 2 + 2;
            var levelsNeeded = levelForMax + levelsAfterMax;
            var bottomLevelWidth = levelsNeeded * 2 - 1;


            var startLevel = levelForMax - maxLengthElement?.Index ?? 0;
            var levelSpaces = levelsNeeded;
            var levelWidth = 0;
            var result = new List<string>();
            var wordIndex = 0;
            for (var i = 1; i <= levelsNeeded; i++)
            {
                var levelString = $"{new string(' ', levelSpaces)}";

                if (levelWidth > 0)
                {
                    levelString += "*";
                    if (i >= startLevel && wordIndex < words.Length)
                    {
                        var levelInnerString = $" {words[wordIndex]}";
                        var spacesToCompleteLevel = (i * 2 - 3) - levelInnerString.Length;
                        levelInnerString += new string(' ', spacesToCompleteLevel);
                        levelString += levelInnerString;
                        wordIndex++;
                    }
                    else
                    {
                        levelString += new string(' ', i*2 - 3);
                    }
                    levelString += "*";
                }
                else
                {
                    levelString += '*';
                }

                result.Add(levelString);
                levelWidth++;
                levelSpaces--;

            }
            result.Add(new string('*', bottomLevelWidth + 2));

            return result.ToArray();
        }
    }
}
