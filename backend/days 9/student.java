package school;

import java.util.ArrayList;

public class Student{
private int studentId;
private String studentName;
private Subject majorSubject;

private ArrayList<Score> scoreList = new ArrayList<Score>();
public Student(int studentId, Strubg studentName, Subject majorSubject){

this.studentId=studentId;
this.studentName=studentName;
this.majorSubject=majorSubject;

}

public void addSubjectScore(Score score){
scoreList.add(score);

}
public int getStudentId(){
return studentId;

}

public void setStudentId(int studentId){
this.studentId=studentId;

}

public String getStudentName(){
    return studentName;
}

public void setStudentName(String studentName){
this.studentName=studentName;

}

public Subject getMajorSubject(){
return majorSubject;

}

public void setMajorSubject(Subject majorSubject){
this.majorSubject=majorSubject;

}

public ArrayList<score> getScoreList(){
return scoreList;

}

public void setScoreList(ArrayList<score> scoreList){
this.scoreList=scoreList;

}

}