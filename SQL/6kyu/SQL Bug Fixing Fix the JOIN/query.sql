SELECT 
  j.job_title,
  ROUND(SUM(j.salary) / COUNT(p),2)::float as average_salary,
  COUNT(p.id) as total_people,
  ROUND(SUM(j.salary),2)::float as total_salary
FROM people p 
  INNER JOIN job j ON p.id = j.people_id
GROUP BY j.job_title
ORDER BY average_salary DESC