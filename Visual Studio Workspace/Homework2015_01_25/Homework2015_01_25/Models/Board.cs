using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Homework2015_01_25.Models
{
    public class Board
    {
        static public int Num_of_recom;
        static public int Num_of_not_recom;
        public string Type { get; set; }
        
        [Required(ErrorMessage = "이름을 입력하십시오.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "제목을 입력하십시오.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "본문을 입력하십시오.")]
        public string Text { get; set; }

        [Required(ErrorMessage = "이유를 선택하십시오.")]
        public string Reason { get; set; }

        public String Date_time;

        public bool set_date_time(int year, int month, int day, 
            int hour, int minute, int second)
        {
            bool result = false;
            if (Date_time == null)
            {
                this.Date_time = year + "년 " + month + "월 " + day + "일 " +
                                hour + "시 " + minute + "분 " + second + "초";
                result = true;
            }
            return result;            
        }

        public int get_num_of_recom()
        {
            return Num_of_recom;
        }

        public int get_num_of_not_recom()
        {
            return Num_of_not_recom;
        }
    }
}