# Array / String 教學專案

## 1. 專案簡介

`ArrayandString` 是一個以 `.NET 10` Console Application 為載體的教學型專案，主題聚焦在 `Array` 與 `String`。專案目標不是建立商業系統，也不是單純蒐集題解，而是讓初學者能同時透過文件與可執行程式理解兩者的核心觀念。

本專案適合以下讀者：

- 剛接觸程式設計與資料結構的初學者
- 想用 C# 理解 Array 與 String 的學習者
- 準備演算法面試或 LeetCode 練習的使用者
- 想快速複習基礎觀念的開發者

執行方式如下：

```bash
dotnet restore ArrayandString.sln
dotnet run --project ArrayandString/ArrayandString.csproj
```

程式執行後，會依序輸出：

- Array 基本概念與範例
- String 基本概念與範例
- Array 與 String 的共同點與差異
- 常見錯誤與注意事項
- LeetCode 練習建議

## 2. Array 基本概念

Array 是一組「同型別資料的固定長度集合」。建立陣列時，資料會依序放在一段連續的位置中，因此可以透過索引快速取得指定元素。

Array 的核心特性如下：

- 元素型別相同，例如全部都是 `int`、`double` 或 `char`
- 可用索引直接存取，例如 `scores[0]`
- 長度固定，建立後不能直接增減容量
- 很適合表示已知筆數的資料，例如成績、座標、每日銷售數字

Array 的優點是讀取快速、概念清楚、很適合搭配迴圈走訪。限制則是長度固定，如果資料量經常變動，就可能要重新建立新的陣列。

## 3. String 基本概念

String 用來表示文字內容。在觀念上，可以把它理解成一串依序排列的字元，因此也能透過索引讀取單一字元。

String 的核心特性如下：

- 內容是字元序列
- 可用索引取得 `char`
- 具備很多文字處理方法，例如 `Substring`、`Replace`、`Split`
- 在 C# 中是不可變物件

不可變性代表「看起來像修改字串」的操作，實際上通常會回傳一個新的字串。如果忘記把新結果接回來，原本的字串不會改變。

## 4. Array 與 String 的共同點與差異

兩者的共同點：

- 都可以用索引讀取指定位置的內容
- 都能搭配迴圈進行走訪
- 都是演算法入門時非常常見的資料主題

主要差異如下：

| 面向 | Array | String |
| --- | --- | --- |
| 主要用途 | 儲存同型別資料 | 表示文字內容 |
| 元素內容 | 任一同型別元素 | `char` 序列 |
| 可否直接修改內容 | 可以 | 不可以，會回傳新字串 |
| 長度特性 | 固定長度 | 固定內容，不可變 |
| 常見情境 | 成績、座標、數列 | 姓名、句子、關鍵字、CSV |

從資料結構觀點來看，String 可以視為針對文字處理做了大量封裝的特殊型別；Array 則更通用，可用來存放任何同型別資料。

## 5. C# 中的 Array 使用方式

以下是本專案示範的基本 Array 操作：

```csharp
int[] scores = { 95, 88, 76, 100 };
Console.WriteLine(scores[1]);

scores[2] = 80;

for (int index = 0; index < scores.Length; index++)
{
    Console.WriteLine($"scores[{index}] = {scores[index]}");
}

int[,] seats = { { 1, 0, 1 }, { 0, 1, 1 } };
Console.WriteLine(seats[1, 2]);
```

這段程式說明了幾個重點：

- 一維陣列可直接宣告並初始化
- 可使用索引讀取或修改指定元素
- `Length` 可取得陣列長度
- `for` 迴圈很適合示範「索引 + 內容」的走訪方式
- 二維陣列可用來表示表格狀資料

本專案另外示範了 `Array.Copy`、`Array.Sort`、`Array.Reverse` 與 `Array.IndexOf`，用來說明常見的實用操作。

## 6. C# 中的 String 使用方式

以下是本專案示範的基本 String 操作：

```csharp
string title = "Array and String";
Console.WriteLine(title[0]);
Console.WriteLine(title.Length);

string greeting = "Hello, " + "Qiuzili" + "!";
string topic = title.Substring(10, 6);

string csvLine = "apple,banana,orange";
string replacedLine = csvLine.Replace("orange", "grape");
string[] fruits = csvLine.Split(',');
```

這段程式可以對應到以下觀念：

- 字串可以宣告、初始化並取得長度
- 用索引取得的是 `char`
- 可以用 `+` 做簡單串接
- `Substring` 能擷取部分字串
- `Replace`、`Contains`、`Split` 是常見的文字處理方法

不可變性是最重要的學習點之一，例如：

```csharp
string userName = "alice";
userName.Replace("a", "A");
Console.WriteLine(userName); // 仍然是 alice

userName = userName.Replace("a", "A");
Console.WriteLine(userName); // 變成 Alice
```

原因不是 `Replace` 失效，而是它回傳的是「新的字串結果」。

## 7. 常見使用情境

Array 常見於：

- 儲存固定筆數的成績或測量數據
- 表示座標、表格、棋盤或座位狀態
- 處理數列統計、加總、最大值或最小值

String 常見於：

- 儲存姓名、地址、訊息、句子
- 搜尋關鍵字或檢查格式
- 做文字清理，例如 `Trim`、`Replace`、`Split`

實務上常見的取捨是：

- 若資料重點是「第幾個位置的值」，通常先想到 Array
- 若資料重點是「文字內容如何切割、比對、整理」，通常先想到 String

## 8. 範例程式碼說明

本專案的 Console 程式已依教學主題拆分，方便閱讀與維護：

- `ArrayandString/Program.cs`：主程式入口，負責安排整體輸出順序
- `ArrayandString/ConsoleRenderer.cs`：統一 Console 章節格式與結果顯示
- `ArrayandString/Examples/ArrayExamples.cs`：Array 的概念、走訪、多維與實用操作
- `ArrayandString/Examples/StringExamples.cs`：String 的索引、長度、串接、擷取與不可變性
- `ArrayandString/Examples/ComparisonExamples.cs`：共同點、差異與使用時機比較
- `ArrayandString/Examples/CommonPitfalls.cs`：常見錯誤示範
- `ArrayandString/Examples/PracticeSuggestions.cs`：LeetCode 練習建議

閱讀方式建議如下：

- 先看本 README 建立概念
- 再執行 Console App，觀察每個主題的輸出結果
- 最後回到對應 `.cs` 檔案，理解實際程式如何寫

## 9. 常見錯誤與注意事項

初學者最常遇到的錯誤如下：

- 索引超出範圍：`Array` 與 `String` 都不能讀取不存在的位置
- 忘記 String 不可變：`Replace`、`Trim`、`ToUpper` 等方法通常要接回新結果
- 混淆 `char` 與 `string`：`'A'` 是字元，`"A"` 是字串
- 以為 Array 會自動擴充：陣列長度固定，如果要增加容量，必須建立新陣列

設計上的原因也值得理解：

- Array 強調固定長度與快速索引，適合結構清楚的資料
- String 強調文字安全與方法一致性，不可變性可降低意外修改風險

## 10. LeetCode 練習建議

建議從 Easy 題建立基本功，再進入 Medium 與進階延伸題：

| 順序 | 題目 | 類型 | 難度 | 練習重點 |
| --- | --- | --- | --- | --- |
| 1 | Two Sum | Array / Hashing | Easy | 索引查找、配對思維 |
| 2 | Remove Duplicates from Sorted Array | Array / Two Pointers | Easy | 原地修改、雙指針 |
| 3 | Valid Palindrome | String / Two Pointers | Easy | 字元判斷、左右夾逼 |
| 4 | Longest Common Prefix | String | Easy | 逐字比較、邊界處理 |
| 5 | Best Time to Buy and Sell Stock | Array | Easy | 一次走訪、最佳值更新 |
| 6 | Longest Substring Without Repeating Characters | String / Sliding Window | Medium | 滑動視窗、集合判斷 |
| 7 | Group Anagrams | String / Hashing | Medium | 分類、字串特徵轉換 |
| 8 | Product of Array Except Self | Array / Prefix | Medium | 前後綴乘積、空間思維 |
| 9 | Minimum Window Substring | String / Sliding Window | Hard | 進階視窗控制、計數維護 |

建議順序如下：

- 先熟悉索引、長度、走訪與字元處理
- 再練習雙指針、滑動視窗與雜湊表
- 最後再挑戰需要更強邊界控制的題目

即使不寫完整題解，也要在練習時問自己：

- 這題主要在操作 Array 還是 String？
- 是否需要索引、雙指針或滑動視窗？
- 哪些邊界條件最容易出錯？

## 11. 總結

Array 與 String 是資料結構與演算法學習的第一站。學會它們，不只是會寫語法，更重要的是理解：

- 何時該用固定長度的資料集合
- 何時該用文字處理型別
- 修改資料時是否會影響原始內容
- 如何把基本觀念延伸到實際問題與演算法題目

本專案提供文件與可執行範例兩條學習路線。最好的學習方式，是一邊讀 README、一邊執行程式，並對照原始碼理解每個範例背後的設計理由。
