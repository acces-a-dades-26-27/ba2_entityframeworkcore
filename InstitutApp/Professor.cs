namespace InstitutApp;

public class Professor
{
    public int ProfessorID { get; set; }
    public string Nom { get; set; }
    public string Cognom { get; set; }
    public int HoresAssignades { get; set; }
    public override string ToString()
    {
        return $"Professor {{ProfessorID = {ProfessorID}, Nom = {Nom}, Cognom = {Cognom}, HoresAssignades = {HoresAssignades}}}";
    }
}