---
title: Online Hosted Instructions
permalink: index.html
layout: home
---

# 컨텐츠 디렉토리

각 연습에 대한 하이퍼 링크는 강사가 데모를 하거나 학생이 연습을 할 때 사용할 수 있습니다.

## 연습

{% assign labs = site.pages | where_exp:"page", "page.url contains '/Instructions/Labs'" %}
| 모듈 | 실습 |
| --- | --- | 
{% for activity in labs  %}| {{ activity.lab.module }} | [{{ activity.lab.title }}{% if activity.lab.type %} - {{ activity.lab.type }}{% endif %}]({{ site.github.url }}{{ activity.url }}) |
{% endfor %}
