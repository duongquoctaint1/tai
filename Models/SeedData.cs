using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using cuahangdidong.Data;
using System;
using System.Linq;
namespace cuahangdidong.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new cuahangdidongContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<cuahangdidongContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.didong.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.didong.AddRange(
                new didong
                {
                    ChứVụ = "Atomic Habits",
                    NgàyPhátHành = DateTime.Parse("2018-10-16"),
                    ThểLoại = "Self-Help",
                    GíaBán = 11.98M ,
                    SốLượng = "2" 
    
                },
                new didong
                {
                    ChứVụ = "Dark Roads",
                    NgàyPhátHành = DateTime.Parse("2021-8-3"),
                    ThểLoại = "Novel",
                    GíaBán = 18.59M ,
                    SốLượng = "2" 

                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}