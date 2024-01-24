using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Person
{
    public Guid PersonId { get; set; }

    public string PersonNationalCode { get; set; } = null!;

    public string PersonFirstName { get; set; } = null!;

    public string PersonLastName { get; set; } = null!;

    public string? PersonFatherName { get; set; }

    public string? PersonPreviousName { get; set; }

    public string? PersonCertificatetNo { get; set; }

    public DateTime? PersonDeathDate { get; set; }

    public string? PersonDeathSolarDate { get; set; }

    public string? PersonEmail { get; set; }

    public DateTime? PersonBirthdate { get; set; }

    public string? PersonBirthSolarDate { get; set; }

    public string? PersonBirthPlace { get; set; }

    public string? PersonCountry { get; set; }

    public string? PersonState { get; set; }

    public string? PersonCity { get; set; }

    public string? PersonAddress { get; set; }

    public string? PersonPostalCode { get; set; }

    public int? PersonRegion { get; set; }

    public int? PersonArea { get; set; }

    public string? PersonPhone { get; set; }

    public string? PersonCellPhone { get; set; }

    public string? PersonCellPhone2 { get; set; }

    public Guid? GenderId { get; set; }

    public Guid? MaritalStatusId { get; set; }

    public Guid? EducationTypeId { get; set; }

    public Guid? UniversityId { get; set; }

    public Guid? HousingTypeId { get; set; }

    public bool PersonIsSacrificed { get; set; }

    public bool PersonIsSacrificedFamily { get; set; }

    public bool PersonIsChildOfSacrificed { get; set; }

    public bool PersonIsValiant { get; set; }

    public bool PersonIsCaptive { get; set; }

    public bool PersonIsWarrior { get; set; }

    public bool PersonIsClubMember { get; set; }

    public string? PersonSpecialDisease { get; set; }

    public string? PersonDescription { get; set; }

    public Guid InsertUserId { get; set; }

    public DateTime InsertTime { get; set; }

    public Guid? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual ICollection<PensionaryComplementary> PensionaryComplementaries { get; set; } = new List<PensionaryComplementary>();

    public virtual ICollection<Pensionary> PensionaryParentPeople { get; set; } = new List<Pensionary>();

    public virtual ICollection<Pensionary> PensionaryPeople { get; set; } = new List<Pensionary>();
}
