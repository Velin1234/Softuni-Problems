function filterEmployees(employeesString, criteria) {
    let employeeArray = JSON.parse(employeesString);
    let cmdArgs = criteria.split('-');
    const key = cmdArgs[0];
    const value = cmdArgs[1];
    let counter = 0;

    if (key === 'all') {

        console.log(employeeArray.map(e => `${counter++}. ${e.first_name} ${e.last_name} - ${e.email}`).join('\r\n'));
        return;

    }

    employeeArray = employeeArray.filter(e => e[key] === value);
    console.log(employeeArray.map(e => `${counter++}. ${e.first_name} ${e.last_name} - ${e.email}`).join('\r\n'));
}
