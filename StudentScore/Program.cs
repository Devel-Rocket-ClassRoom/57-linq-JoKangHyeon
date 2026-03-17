using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new List<Student>() {
    new Student("김철수", "수학", 85),
    new Student("김철수", "영어", 78),
    new Student("이영희", "수학", 92),
    new Student("이영희", "영어", 88),
    new Student("박민수", "수학", 76),
    new Student("박민수", "영어", 82),
    new Student("정지은", "수학", 95),
    new Student("정지은", "영어", 91),
};


Console.WriteLine("=== 문제 1: 85점 이상 ===");
foreach (var result in students
    .Where(x => x.Score >= 85)
    .Select(x => $"{x.Name} - {x.Subject}: {x.Score}점"))
{
    Console.WriteLine(result);
}


Console.WriteLine();
Console.WriteLine("=== 문제 2: 수학 과목 ===");
foreach (var result in students
    .Where(x => x.Subject == "수학")
    .Select(x => $"{x.Name} - {x.Subject}: {x.Score}점"))
{
    Console.WriteLine(result);
}


Console.WriteLine();
Console.WriteLine("=== 문제 3: 점수 내림차순 ===");
foreach (var result in students
    .OrderByDescending(x => x.Score)
    .Select(x => $"{x.Name} - {x.Subject}: {x.Score}점"))
{
    Console.WriteLine(result);
}


Console.WriteLine();
Console.WriteLine("=== 문제 4: 전체 평균 ===");
Console.WriteLine(students.Average(x => x.Score));


Console.WriteLine();
Console.WriteLine("=== 문제 5: 수학 최고/최저 점수 ===");
int mathMax = students.Where(x => x.Subject == "수학").Max(x => x.Score);
int mathMin = students.Where(x => x.Subject == "수학").Min(x => x.Score);
Console.WriteLine($"최고: {mathMax}");
Console.WriteLine($"최저: {mathMin}");


Console.WriteLine();
Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");
Console.WriteLine(students.Where(x => x.Subject == "영어").Any(x => x.Score >= 90));


Console.WriteLine();
Console.WriteLine("=== 문제 7: 모두 70점 이상 여부 ===");
Console.WriteLine(students.GroupBy(x => x.Name).Any(x => x.All(x => x.Score >= 70)));


Console.WriteLine();
Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");
foreach (var result in students
    .Select(x => x.Name)
    .Distinct())
{
    Console.WriteLine(result);
}


Console.WriteLine();
Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");
string mathMaxName = students
    .Where(x => x.Subject == "수학")
    .OrderByDescending(x => x.Score)
    .First().Name;
Console.WriteLine(mathMaxName);


Console.WriteLine();
Console.WriteLine("=== 문제 10: 과목별 정렬 ===");
foreach (var result in students
    .OrderBy(x => x.Subject)
    .ThenByDescending(x => x.Score)
    .Select(x => $"{x.Name} - {x.Subject}: {x.Score}점"))
{
    Console.WriteLine(result);
}
