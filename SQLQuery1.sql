CREATE TABLE QuestionCreator (
    creator_id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255),
     status VARCHAR(20) DEFAULT 'pending'
);
CREATE TABLE Admin (
    admin_id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255)
);
CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    user_name VARCHAR(50) NOT NULL,
    email VARCHAR(255),
    password VARCHAR(255)
);
CREATE TABLE Quiz (
    quiz_id INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(255),
    difficulty VARCHAR(50),
    subject VARCHAR(100),
    time_limit INT, 
    created_by INT,
    FOREIGN KEY (created_by) REFERENCES QuestionCreator(creator_id)
);
CREATE TABLE Questions (
    question_id INT PRIMARY KEY IDENTITY(1,1),
    quiz_id INT,
    content TEXT,
    option_a VARCHAR(255),
    option_b VARCHAR(255),
    option_c VARCHAR(255),
    option_d VARCHAR(255),
    correctAnswer VARCHAR(255),
    FOREIGN KEY (quiz_id) REFERENCES Quiz(quiz_id)
);
CREATE TABLE UsersQuizStatus (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    quiz_id INT,
    status VARCHAR(20),
    score INT,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (quiz_id) REFERENCES Quiz(quiz_id)
);
