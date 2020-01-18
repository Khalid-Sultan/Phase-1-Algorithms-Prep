/*
// Employee info
class Employee {
    // It's the unique id of each node;
    // unique id of this employee
    public int id;
    // the importance value of this employee
    public int importance;
    // the id of direct subordinates
    public List<Integer> subordinates;
};
*/
class Solution {
    public int getImportance(List<Employee> employees, int id) {
        Map<Integer, Employee> map = new HashMap();
        for(Employee emp : employees){
            map.put(emp.id, emp);
        }
        return dfs(id, map);
    }
    public int dfs(int id, Map<Integer, Employee> map){
        Employee emp = map.get(id);
        int importance = emp.importance;
        for(Integer subordinate : emp.subordinates){
            importance += dfs(subordinate, map);
        }
        return importance;
    }
}