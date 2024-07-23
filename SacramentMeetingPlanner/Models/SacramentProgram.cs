using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models;


public class SacramentProgram
{
    public int Id { get; set; }
    [Display(Name = "Meeting Date")]
    [DataType(DataType.Date)]
    public DateTime MeetingDate { get; set; }
    [Required]
    [StringLength(40)]
    [Display(Name = "Conducting Leader")] 
    public string? ConductingLeader { get; set; }
    [Required]
    [StringLength(30)]
    [Display(Name = "Opening Song")]
    public string? OpeningSong { get; set; }
    [Required]
    [StringLength(40)]
    [Display(Name = "Opening Prayer")] 
    public string? OpeningPrayer { get; set; }
    [Required]
    [StringLength(30)]
    [Display(Name = "Sacrament Hymn")] 
    public string? SacramentHymn { get; set; }
    [Required]
    [StringLength(40)]
    [Display(Name = "1st Speaker")] 
    public string? Speaker1 { get; set; }
    [Required]
    [StringLength(30)]
    [Display(Name = "Subject")] 
    public string? Speaker1Subject { get; set; }
    [Required]
    [StringLength(40)]
    [Display(Name = "2nd Speaker")] 
    public string? Speaker2 { get; set; }
    [Required]
    [StringLength(30)]
    [Display(Name = "Subject")]
    public string? Speaker2Subject { get; set; }
    [StringLength(40)]
    [Display(Name = "3rd Speaker")]
    public string? Speaker3 { get; set; }
    [StringLength(30)]
    [Display(Name = "Subject")] 
    public string? Speaker3Subject { get; set; }
    [Required]
    [StringLength(30)]
    [Display(Name = "Closing Song")]
    public string? ClosingSong { get; set; }
    [Required]
    [StringLength(40)]
    [Display(Name = "Closing Prayer")]
    public string? ClosingPrayer { get; set; }
}