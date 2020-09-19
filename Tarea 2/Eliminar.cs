public static bool Eliminar(int id){
	bool paso = false;
	Contexto contexto = new Contexto();

	try{
	var	estudiantes = contexto.Estudiantes.Find(id);

	if(estudiantes != null){
		contexto.Estudiantes.Remove(estudiantes);
		paso = contexto.SaveChanges() > 0;
	}
}
	catch (Exception){
		throw;
	}
	finally{
		contexto.Dispose();
	}

	return estudiantes;
}