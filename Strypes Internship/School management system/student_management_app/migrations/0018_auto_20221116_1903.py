# Generated by Django 3.0.7 on 2022-11-16 17:03

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('student_management_app', '0017_auto_20221116_1845'),
    ]

    operations = [
        migrations.AlterField(
            model_name='message',
            name='admin',
            field=models.OneToOneField(default=1, on_delete=django.db.models.deletion.DO_NOTHING, to=settings.AUTH_USER_MODEL),
        ),
    ]
