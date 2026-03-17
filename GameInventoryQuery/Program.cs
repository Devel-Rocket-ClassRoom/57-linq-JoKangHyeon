using System;
using System.Collections.Generic;
using System.Linq;

List<GameItem> gameItems = new() {
new("나무 검",     "무기",   "일반", 100,  3),
new("강철 대검",   "무기",   "희귀", 800,  1),
new("용의 검",     "무기",   "전설", 5000, 1),
new("가죽 갑옷",   "방어구", "일반", 200,  2),
new("미스릴 갑옷", "방어구", "희귀", 1200, 1),
new("드래곤 갑옷", "방어구", "전설", 8000, 0),
new("체력 물약",   "소비",   "일반", 50,   10),
new("마나 물약",   "소비",   "일반", 80,   5),
new("고급 물약",   "소비",   "희귀", 500,  0),
new("엘릭서",      "소비",   "전설", 3000, 2),
};

Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");

foreach (var item in gameItems.Where(x => x.Price >= 500)
                              .OrderByDescending(x => x.Price))
{
    Console.WriteLine($"{item.Name} - {item.Type} - {item.Price}원");
}


Console.WriteLine();
Console.WriteLine("=== 쿼리 2: 무기 타입 (등급순) ===");
foreach (var item in gameItems.Where(x => x.Type is "무기")
                              .OrderBy(x => x.Grade switch
                              {
                                  "일반" => 1,
                                  "희귀" => 2,
                                  "전설" => 3,
                                  _ => 0
                              }))
{
    Console.WriteLine($"{item.Name} - {item.Grade} - {item.Price}원");
}


Console.WriteLine();
Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
foreach (var item in gameItems.Where(x => x.Price * x.Quantity >= 1000))
{
    Console.WriteLine($"{item.Name} - 총 가치: {item.Price * item.Quantity}원");
}

Console.WriteLine();
Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
foreach (var item in gameItems.Where(x => x.Quantity == 0)
                              .OrderBy(x => x.Name))
{
    Console.WriteLine($"{item.Name}");
}


Console.WriteLine();
Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");

foreach (var item in gameItems.Where(x => x.Grade == "전설")
                              .OrderByDescending(x => x.Price))
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}
